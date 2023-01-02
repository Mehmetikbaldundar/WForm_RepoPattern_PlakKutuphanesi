using DataAccess.Concrete;
using DataAccess.Context;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presantation
{
    public partial class Albumler : Form
    {
        private readonly MyDbContext _sirketDbContext;
        private readonly AlbumRepository _albumRepository;        
        public Albumler()
        {
            _sirketDbContext = new MyDbContext();
            _albumRepository = new AlbumRepository(_sirketDbContext);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.Name = textBox1.Text;
            album.Artist = textBox2.Text;
            album.ReleaseDate = dateTimePicker1.Value;
            album.Price = Convert.ToDecimal(textBox3.Text);
            album.DiscountRate = numericUpDown1.Value;
            if (radioButton1.Checked)
                album.SaleStatus = SaleStatus.OnSale;
            if (radioButton2.Checked)
                album.SaleStatus = SaleStatus.OutOfSale;

            _albumRepository.Add(album);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _albumRepository.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyDbContext db = new MyDbContext();
            dataGridView1.DataSource = db.Albums
                .Where(a => a.SaleStatus == SaleStatus.OnSale)
                .Select(x => new
                {
                    x.Name,
                    x.Artist,
                }) .ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyDbContext db = new MyDbContext();
            dataGridView1.DataSource = db.Albums
                .Where(a => a.SaleStatus == SaleStatus.OutOfSale)
                .Select(x => new
                {
                    x.Name,
                    x.Artist,
                }).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyDbContext db = new MyDbContext();
            dataGridView1.DataSource = db.Albums                
                .Select(x => new
                {
                    x.Name,
                    x.Artist,
                    x.ID
                }).OrderByDescending(x=>x.ID).Take(10).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MyDbContext db = new MyDbContext();
            dataGridView1.DataSource = db.Albums
                .Where(a => a.DiscountRate != 0)
                .Select(x => new
                {                    
                    x.Name,
                    x.Artist,
                    x.DiscountRate
                }).OrderByDescending(x => x.DiscountRate).ToList();
        }
        int dgvAlbumSelection;
        int searchingAlbumID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dgvAlbumSelection = dataGridView1.CurrentCell.RowIndex;         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchingAlbumID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            var deletingAlbum = _albumRepository.GetById(searchingAlbumID);
            deletingAlbum.DeletedDate = DateTime.Now;
            _albumRepository.Delete(deletingAlbum);
            dataGridView1.DataSource = _albumRepository.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchingAlbumID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            var updatingAlbum = _albumRepository.GetById(searchingAlbumID);
            updatingAlbum.Name = textBox1.Text;
            updatingAlbum.Artist = textBox2.Text;
            updatingAlbum.ReleaseDate = dateTimePicker1.Value;
            updatingAlbum.Price = Convert.ToDecimal(textBox3.Text);
            updatingAlbum.DiscountRate = numericUpDown1.Value;
            if (radioButton1.Checked)
                updatingAlbum.SaleStatus = SaleStatus.OnSale;
            if (radioButton2.Checked)
                updatingAlbum.SaleStatus = SaleStatus.OutOfSale;
            _albumRepository.Update(updatingAlbum);
            dataGridView1.DataSource = _albumRepository.GetAll();
        }
    }
}

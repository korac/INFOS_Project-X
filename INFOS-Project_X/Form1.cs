﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INFOS_Project_X
{
    public partial class Form1 : Form
    {
        
        //infosXDatabaseDataSet ds = new infosXDatabaseDataSet();
        //infosXDatabaseDataSetTableAdapters.MjestoTableAdapter mjestoTA = new infosXDatabaseDataSetTableAdapters.MjestoTableAdapter();
        //infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter drzavaTA = new infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter();
        //infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter drustvoTA = new infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter();
        //infosXDatabaseDataSetTableAdapters.ClanTableAdapter clanTA = new infosXDatabaseDataSetTableAdapters.ClanTableAdapter();

        public Form1()
        {
            InitializeComponent();
            //mjestoTA.Fill(ds.Mjesto);
            //drzavaTA.Fill(ds.Drzava);
            //drustvoTA.Fill(ds.Drustvo);
            //clanTA.Fill(ds.Clan);

            Console.WriteLine("Bravo!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvMjesta.AutoGenerateColumns = true;
            //dgvDrzava.AutoGenerateColumns = true;

            //dgvMjesta.DataSource = ds.Mjesto;
            //dgvDrzava.DataSource = ds.Drzava;
            //infosXDatabaseDataSet1.Mjesto.Count;
        }

        private void ClearMdiChildren()
        {
            foreach (var a in this.MdiChildren)
            {
                a.Close();
            }
        }

        private void tsmiClan_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Clan);
        }

        private void tsmiDrustvo_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Drustva);
        }

        private void tsmiMjesto_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Mjesta);
        }

        private void tsmiDrzava_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Drzave);
        }

        private void menuItemClickHandler(MaticniPodaci matpod)
        {
            ClearMdiChildren();
            Form2 newMDIChild       = new Form2(matpod, false);
            // Set the Parent Form of the Child window
            newMDIChild.MdiParent   = this;
            // Display the new form
            newMDIChild.Show();
            newMDIChild.WindowState = FormWindowState.Maximized;
        }
        
        private void tsmiIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
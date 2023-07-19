﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippieDog_BanhoTosa
{
    public partial class FormFinanceiro : Form
    {

        NEGOCIOS.NEG_BANHOETOSA ObjNeg = new NEGOCIOS.NEG_BANHOETOSA();
        public FormFinanceiro()
        {
            InitializeComponent();
        }

        private void FormFinanceiro_Load(object sender, EventArgs e)
        {
            // Suponha que a semana desejada seja de segunda-feira a domingo
            DateTime dataInicioSemana = new DateTime(2023, 7, 10); // Defina a data de início da semana
            DateTime dataFimSemana = new DateTime(2023, 7, 15); // Defina a data de fim da semana

            DateTime dataInicioMes = new DateTime(2023, 7, 1);
            DateTime dataFimMes = new DateTime(2023, 7, 30);


            dgvHistBanhos.DataSource = ObjNeg.ListarHistorico();
            textBox1.Text = ObjNeg.GanhosDiarios().ToString(); 
            tbxRendaSemanal.Text = ObjNeg.GanhosSemanais(dataInicioSemana, dataFimSemana).ToString();
            tbxRendaMensal.Text = ObjNeg.GanhosMensal(dataInicioMes, dataFimMes).ToString();
            tbxBanhosSemanais.Text = ObjNeg.BanhosSemanais(dataInicioSemana, dataFimSemana).ToString();
            tbxBanhosMensais.Text = ObjNeg.BanhosMensais(dataInicioMes, dataFimMes).ToString();

         

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmReservaItemAcervo
{
	public partial class FrmReservaItemAcervo : Form
	{
		public FrmReservaItemAcervo()
		{
			InitializeComponent();
		}

		public void SelecionarItens()
		{
			FrmSelecionarItemAcervo selecionar = new FrmSelecionarItemAcervo();
			selecionar.TipoMovimento = cbxTipoMovimento.Text;
			selecionar.ShowDialog();
			txtCodigoItem.Text = selecionar.CodItem;
			txtNomeItem.Text = selecionar.NomeItem;
			txtLocalizacao.Text = selecionar.Localizacao;
			txtNumExemplar.Text = selecionar.NumExemplar;
			txtTipoItem.Text = selecionar.TipoItem;

		}
		public void SelecionarLeitor()
		{
			FrmSelecionarLeitor selecionar = new FrmSelecionarLeitor();
			selecionar.ShowDialog();
			txtCodLeitor.Text = selecionar.Codleitor;
			txtNomeLeitor.Text = selecionar.NomeLeitor;

		}

		private void CarregarReservasItensgrid()
		{
			gridLayout.Rows.Clear();
			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				ReservaDAO dao = new ReservaDAO(connection);
				List<ReservaModel> reservas = dao.GetReservas();
				foreach (ReservaModel reserva in reservas)
				{
					DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
					row.Cells[colCodItem.Index].Value = reserva.ItemAcervoModel.CodItem;
					row.Cells[colNomeItem.Index].Value = reserva.ItemAcervoModel.NomeItem;
					row.Cells[colSitucao.Index].Value = reserva.Situacao;
					row.Cells[colDataReserva.Index].Value = reserva.DataReserva.Substring(0, 10);
					row.Cells[colDataRetorno.Index].Value = reserva.PrazoReserva.Substring(0, 10);
				}
			}
		}
		private void lblSelecionarItemAcervo_Click(object sender, EventArgs e)
		{


		}

		private void FrmReservaItemAcervo_Load(object sender, EventArgs e)
		{
			CarregarReservasItensgrid();
		}

		private void cbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTipoMovimento.Text == "Reservar")
			{
				cbxSituacao.Text = "Reservado";
				txtCodLeitor.Enabled = true;
			}
			else if (cbxTipoMovimento.Text == "Devolver")
			{
				cbxSituacao.Text = "Disponivel";
				dtpDataReserva.Enabled = false;
				txtCodLeitor.Enabled=false;
			}
		}
		public void Limpar()
		{
			txtCodigoItem.Text = "";
			txtNumExemplar.Text = "";
			txtLocalizacao.Text = "";
			txtNomeItem.Text = "";
			txtTipoItem.Text = "";
			txtCodLeitor.Text = "";
			txtNomeLeitor.Text = "";
			cbxSituacao.SelectedIndex = -1;
			cbxTipoMovimento.SelectedIndex = -1;
			dtpDataReserva.Text = null;
			dtpPrazoReserva.Text = null;
		}
		private void cbxTipoMovimento_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnSelecionarItemAcervo_Click(object sender, EventArgs e)
		{
			SelecionarItens();
		}

		private void btnSelecionarLeitor_Click(object sender, EventArgs e)
		{
			SelecionarLeitor();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = DaoConnection.GetConexao())
				{
					ReservaDAO dao = new ReservaDAO(connection);
					bool verificaRegistros = dao.Validacao(new ReservaModel()
					{
						TipoMovimento = cbxTipoMovimento.Text,
						DataReserva = dtpDataReserva.Text,
						PrazoReserva = dtpPrazoReserva.Text

					}, new LeitorModel()
					{
						CodLeitor = txtCodLeitor.Text

					}, new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});
					txtNomeLeitor.Text = dao.GetNomeLeitor(new LeitorModel()
					{
						CodLeitor = txtCodLeitor.Text
					});

					txtNomeItem.Text = dao.GetNomeItem(new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});

					txtNumExemplar.Text = dao.GetNumExemplar(new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});

					txtTipoItem.Text = dao.GetTipoItem(new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});

					txtLocalizacao.Text = dao.GetLocalizacao(new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});

					if (verificaRegistros)
					{
						int count = dao.Verificacao(new ItemAcervoModel()
						{
							CodItem = txtCodigoItem.Text
						});

						dao.Salvar(new ReservaModel()
						{
							TipoMovimento = cbxTipoMovimento.Text,
							DataReserva = dtpDataReserva.Value.Date.ToString(),
							PrazoReserva = dtpPrazoReserva.Value.Date.ToString(),
							Situacao = cbxSituacao.Text

						}, new LeitorModel()
						{
							CodLeitor = txtCodLeitor.Text,
							NomeLeitor = txtNomeLeitor.Text

						}, new ItemAcervoModel()
						{
							CodItem = txtCodigoItem.Text,
							NomeItem = txtNomeItem.Text,
							NumExemplar = txtNumExemplar.Text,
							TipoItem = txtTipoItem.Text,
							Localizacao = txtLocalizacao.Text

						});
						dao.AlterarStatus(new ItemAcervoModel()
						{
							CodItem = txtCodigoItem.Text
						}, new ReservaModel()
						{
							Situacao = cbxSituacao.Text
						});
						MessageBox.Show("Registrado com sucesso!");
						Limpar();
					}
					CarregarReservasItensgrid();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Houve um problema ao salvar o item do acervo!\n{ex.Message}");
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Limpar();
		}

		private void txtCodigoItem_TextChanged(object sender, EventArgs e)
		{

			if (cbxTipoMovimento.Text == "Devolver")
			{
				using (SqlConnection connection = DaoConnection.GetConexao())
				{
					ReservaDAO dao = new ReservaDAO(connection);
					txtNomeLeitor.Text = dao.GetLeitorAuto(new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});
					txtCodLeitor.Text = dao.GetCodLeitorAuto(new ItemAcervoModel()
					{
						CodItem = txtCodigoItem.Text
					});

				}
			}
		}	
	}
}
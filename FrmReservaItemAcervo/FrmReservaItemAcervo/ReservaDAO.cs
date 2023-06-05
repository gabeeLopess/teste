using FrmReservaItemAcervo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmReservaItemAcervo
{
	public class ReservaDAO
	{
		private SqlConnection Connection { get; }
		public ReservaDAO(SqlConnection connection)
		{
			Connection = connection;
		}
		public void Salvar(ReservaModel Reserva, ItemAcervoModel Item, LeitorModel Leitor)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				SqlTransaction t = Connection.BeginTransaction();
				try
				{
					StringBuilder sql = new StringBuilder();
					sql.AppendLine($"INSERT INTO mvtBibReserva(codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, tipoMovimento) VALUES(@codItem, @situacao, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor, @dataReserva, @prazoReserva, @tipoMovimento)");
					command.CommandText = sql.ToString();
					command.Parameters.Add(new SqlParameter("@codItem", Item.CodItem));
					command.Parameters.Add(new SqlParameter("@situacao", Reserva.Situacao));
					command.Parameters.Add(new SqlParameter("@nomeItem", Item.NomeItem));
					command.Parameters.Add(new SqlParameter("@numExemplar", Item.NumExemplar));
					command.Parameters.Add(new SqlParameter("@tipoItem", Item.TipoItem));
					command.Parameters.Add(new SqlParameter("@localizacao", Item.Localizacao));
					command.Parameters.Add(new SqlParameter("@codLeitor", Leitor.CodLeitor));
					command.Parameters.Add(new SqlParameter("@nomeLeitor", Leitor.NomeLeitor));
					command.Parameters.Add(new SqlParameter("@dataReserva", Reserva.DataReserva));
					command.Parameters.Add(new SqlParameter("@prazoReserva", Reserva.PrazoReserva));
					command.Parameters.Add(new SqlParameter("@tipoMovimento", Reserva.PrazoReserva));
					command.Transaction = t;
					command.ExecuteNonQuery();
					t.Commit();
				}

				catch (Exception ex)
				{
					t.Rollback();
					throw ex;
				}
			}
		}
		public void AlterarStatus(ReservaModel Reserva, ItemAcervoModel Item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				SqlTransaction t = Connection.BeginTransaction();
				try
				{
					StringBuilder sql = new StringBuilder();
					sql.AppendLine($"UPDATE mvtBibItemAcervo SET tipoStatus = @situacao WHERE codItem = @codItem");
					command.CommandText = sql.ToString();
					command.Parameters.Add(new SqlParameter("@codItem", Item.CodItem));
					command.Parameters.Add(new SqlParameter("@situacao", Reserva.Situacao));
					command.Transaction = t;
					command.ExecuteNonQuery();
					t.Commit();
				}

				catch (Exception ex)
				{
					t.Rollback();
					throw ex;
				}
			}
		}
		public bool Validacao(ReservaModel Reserva, LeitorModel Leitor, ItemAcervoModel Item)
		{
			if (string.IsNullOrEmpty(Reserva.TipoMovimento) || string.IsNullOrWhiteSpace(Reserva.TipoMovimento))
			{
				MessageBox.Show("Informe o campo Tipo movimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (string.IsNullOrEmpty(Item.CodItem) || string.IsNullOrWhiteSpace(Item.CodItem))
			{
				MessageBox.Show("Informe o campo Codigo Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (string.IsNullOrEmpty(Leitor.CodLeitor) || string.IsNullOrWhiteSpace(Leitor.CodLeitor))
			{
				MessageBox.Show("Informe o campo Codigo Leitor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (string.IsNullOrEmpty(Reserva.DataReserva) || string.IsNullOrWhiteSpace(Reserva.DataReserva))
			{
				MessageBox.Show("Informe o campo Data reserva", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (string.IsNullOrEmpty(Reserva.PrazoReserva) || string.IsNullOrWhiteSpace(Reserva.PrazoReserva))
			{
				MessageBox.Show("Informe o campo Prazo Reserva", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}
		public int Verificacao(ItemAcervoModel Item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT COUNT(codItem) FROM mvtBibReserva WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", Item.CodItem);
				int count = Convert.ToInt32(command.ExecuteScalar());
				return count;
			}
		}
		public string GetLeitorAuto(ItemAcervoModel Item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT nomeLeitor FROM mvtBibReserva WHERE  situacao = 'Reservado' and codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", Item.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public string GetCodLeitorAuto(ItemAcervoModel Item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT codLeitor FROM mvtBibReserva WHERE  situacao = 'Reservado' and codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", Item.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public string GetNomeLeitor(LeitorModel leitor)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT Leitor FROM mvtBibLeitor WHERE  codLeitor = @codLeitor");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codLeitor", leitor.CodLeitor);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public string GetNomeItem(ItemAcervoModel item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT nome FROM mvtBibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", item.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public string GetNumExemplar(ItemAcervoModel item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT numExemplar FROM mvtBibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", item.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public string GetTipoItem(ItemAcervoModel item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT tipoItem FROM mvtBibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", item.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public string GetLocalizacao(ItemAcervoModel item)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT nomeLocal FROM mvtBibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", item.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}
		public List<ReservaModel> GetReservas()
		{
			List<ReservaModel> reservas = new List<ReservaModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar, tipoMovimento FROM mvtBibReserva ORDER BY codItem");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						reservas.Add(PopulateDrReserva(dr));
					}
				}
			}
			return reservas;
		}
		public ReservaModel PopulateDrReserva(SqlDataReader dr)
		{
			string dataReserva = "";
			string prazoReserva = "";
			string encerrar = "";
			string tipoMovimento = "";
			string situacao = "";
			LeitorModel codLeitor = null;
			ItemAcervoModel codItem = null;

			if (DBNull.Value != dr["dataReserva"])
			{
				dataReserva = dr["dataReserva"] + "";
			}
			if (DBNull.Value != dr["prazoReserva"])
			{
				prazoReserva = dr["prazoReserva"] + "";
			}
			if (DBNull.Value != dr["encerrar"])
			{
				encerrar = dr["encerrar"] + "";
			}
			if (DBNull.Value != dr["tipoMovimento"])
			{
				tipoMovimento = dr["tipoMovimento"] + "";
			}
			if (DBNull.Value != dr["situacao"])
			{
				situacao = dr["situacao"] + "";
			}
			if (DBNull.Value != dr["codLeitor"])
			{
				string leitorCod = dr["codLeitor"] + "";
				string nomeLeitor = dr["nomeLeitor"] + "";
				codLeitor = new LeitorModel()
				{
					CodLeitor = leitorCod,
					NomeLeitor = nomeLeitor
				};
			}
			if (DBNull.Value != dr["codItem"])
			{
				string itemCod = dr["codItem"] + "";
				string nomeItem = dr["nomeItem"] + "";
				string numExemplar = dr["numExemplar"] + "";
				string tipoItem = dr["tipoItem"] + "";
				string localizacao = dr["localizacao"] + "";
				codItem = new ItemAcervoModel()
				{
					CodItem = itemCod,
					NomeItem = nomeItem,
					NumExemplar = numExemplar,
					TipoItem = tipoItem,
					Localizacao = localizacao
				};
			}

			return new ReservaModel()
			{
				DataReserva = dataReserva,
				PrazoReserva = prazoReserva,
				TipoMovimento = tipoMovimento,
				Situacao = situacao,
				LeitorModel = codLeitor,
				ItemAcervoModel = codItem,
				Encerrar = encerrar
			};
		}

		internal void Salvar(ReservaModel reservaModel, LeitorModel leitorModel, ItemAcervoModel itemAcervoModel)
		{
			throw new NotImplementedException();
		}

		internal void AlterarStatus(ItemAcervoModel itemAcervoModel, ReservaModel reservaModel)
		{
			throw new NotImplementedException();
		}
	}
}



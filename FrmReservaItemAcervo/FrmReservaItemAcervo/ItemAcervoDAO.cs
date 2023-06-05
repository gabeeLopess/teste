using FrmReservaItemAcervo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmReservaItemAcervo
{
	public class ItemAcervoDAO
	{
		private SqlConnection Connection { get; }

		public ItemAcervoDAO(SqlConnection connection)
		{
			Connection = connection;
		}


		public List<ItemAcervoModel> GetItens()
		{
			List<ItemAcervoModel> itens = new List<ItemAcervoModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT codItem, nome, numExemplar, tipoItem, localizacao FROM mvtBibItemAcervo WHERE tipoStatus = 'Disponivel' ORDER BY codItem");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						itens.Add(PopulateDr(dr));
					}
				}
			}
			return itens;
		}
		public List<ItemAcervoModel> GetTipoItens()
		{
			List<ItemAcervoModel> itens = new List<ItemAcervoModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT codItem, nome, numExemplar, tipoItem, localizacao FROM mvtBibItemAcervo WHERE tipoStatus = 'Reservado' OR tipoStatus = 'Emprestado' ORDER BY codItem");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						itens.Add(PopulateDr(dr));
					}
				}
			}
			return itens;
		}

		public ItemAcervoModel PopulateDr(SqlDataReader dr)
		{
			string codItem = "";
			string nome = "";
			string numExemplar = "";
			string tipoItem = "";
			string localizacao = "";

			if (DBNull.Value != dr["codItem"])
			{
				codItem = dr["codItem"] + "";
			}
			if (DBNull.Value != dr["nome"])
			{
				nome = dr["nome"] + "";
			}
			if (DBNull.Value != dr["numExemplar"])
			{
				numExemplar = dr["numExemplar"] + "";
			}
			if (DBNull.Value != dr["tipoItem"])
			{
				tipoItem = dr["tipoItem"] + "";
			}
			if (DBNull.Value != dr["localizacao"])
			{
				localizacao = dr["localizacao"] + "";
			}
			return new ItemAcervoModel()
			{
				CodItem = codItem,
				NomeItem = nome,
				NumExemplar = numExemplar,
				TipoItem = tipoItem,
				Localizacao = localizacao,

			};
		}

	}
}
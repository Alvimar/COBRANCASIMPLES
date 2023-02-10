using DevExpress.XtraEditors.Filtering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobrancaSimples.Code
{
    internal class DBASE
    {
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            //var dbPath = @"Data Source=D:\Alvimar\Documentos\Prológica\Clientes\HYTECH\LATAM\Etiquetas\Etiquetas\Release\Data\db-DESKTOP-IODIJ5C.db;Version=3;"; // Application.StartupPath + "/Data/db-" + PCinfos.SystemName() + ".db";

            var dbPath = $"Data Source={Application.StartupPath}\\Data\\Dados.db;Version=3;";

            sqliteConnection = new SQLiteConnection(dbPath, true);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        internal static Cobranca GetCobrancaByNome(string nome)
        {
            Cobranca ret = new Cobranca();
            SQLiteDataAdapter da = null;
            string sql = "Select * from Cobranca Where Autor Like '%" + nome + "%' OR Reu Like '%" + nome + "%'";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    //cmd.Parameters.AddWithValue("@Nome", nome);
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    using (IDataReader rdr = cmd.ExecuteReader())
                    {
                        //PEGAR SOMENTE O 1O RETORNADO
                        if (rdr.Read())
                        {
                            ret.Id = rdr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["Id"]);
                            ret.Numero = rdr["Numero"] == DBNull.Value ? "" : rdr["Numero"].ToString();
                            ret.Autor = rdr["Autor"] == DBNull.Value ? string.Empty : rdr["Autor"].ToString(); ;
                            ret.Reu = rdr["Reu"] == DBNull.Value ? string.Empty : rdr["Reu"].ToString();
                            ret.ValorDaCausa = rdr["ValorDaCausa"] == DBNull.Value ? 0 : Convert.ToSingle(rdr["ValorDaCausa"]);
                            ret.ValorAtualizado = rdr["ValorAtualizado"] == DBNull.Value ? 0 : Convert.ToSingle(rdr["ValorAtualizado"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static Cobranca GetCobrancaByNumero(string numero)
        {
            Cobranca ret = new Cobranca();
            SQLiteDataAdapter da = null;
            string sql = "Select * from Cobranca Where Numero = @Numero";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    using (IDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            ret.Id = rdr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["Id"]);
                            ret.Numero = rdr["Numero"] == DBNull.Value ? "" : rdr["Numero"].ToString();
                            ret.Autor = rdr["Autor"] == DBNull.Value ? string.Empty : rdr["Autor"].ToString(); ;
                            ret.Reu = rdr["Reu"] == DBNull.Value ? string.Empty : rdr["Reu"].ToString();
                            ret.ValorDaCausa = rdr["ValorDaCausa"] == DBNull.Value ? 0 : Convert.ToSingle(rdr["ValorDaCausa"]);
                            ret.ValorAtualizado = rdr["ValorAtualizado"] == DBNull.Value ? 0 : Convert.ToSingle(rdr["ValorAtualizado"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static int SetCobranca(Cobranca cobranca)
        {
            int ret = 0;
            string sql = "INSERT INTO Cobranca (Numero, Autor, Reu, ValorDaCausa, ValorAtualizado) VALUES (@Numero, @Autor, @Reu, @ValorDaCausa, @ValorAtualizado)";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Numero", cobranca.Numero);
                    cmd.Parameters.AddWithValue("@Autor", cobranca.Autor);
                    cmd.Parameters.AddWithValue("@Reu", cobranca.Reu);
                    cmd.Parameters.AddWithValue("@ValorDaCausa", cobranca.ValorDaCausa);
                    cmd.Parameters.AddWithValue("@ValorAtualizado", cobranca.ValorAtualizado);

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static int UpdateCobranca(Cobranca cobranca)
        {
            int ret = 0;
            string sql = "UPDATE COBRANCA SET Numero = @Numero, Autor = @Autor, Reu = @Reu, ValorDaCausa = @ValorDaCausa, ValorAtualizado = @ValorAtualizado WHERE Id = @Id";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", cobranca.Id);
                    cmd.Parameters.AddWithValue("@Numero", cobranca.Numero);
                    cmd.Parameters.AddWithValue("@Autor", cobranca.Autor);
                    cmd.Parameters.AddWithValue("@Reu", cobranca.Reu);
                    cmd.Parameters.AddWithValue("@ValorDaCausa", cobranca.ValorDaCausa);
                    cmd.Parameters.AddWithValue("@ValorAtualizado", cobranca.ValorAtualizado);

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static int DeleteCobranca(int idCobranca)
        {
            int ret = 0;
            string sql = "DELETE FROM COBRANCA WHERE ID = @IdCobranca)";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@IdCobranca", idCobranca);

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static int SetHistorico(Historico historico)
        {
            int ret = 0;
            string sql = "INSERT INTO HISTORICO (Data, Evento, Descricao, IdCobranca) VALUES (@Data, @Evento, @Descricao, @IdCobranca)";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Data", historico.Data);
                    cmd.Parameters.AddWithValue("@Evento", historico.Evento);
                    cmd.Parameters.AddWithValue("@Descricao", historico.Descricao);
                    cmd.Parameters.AddWithValue("@IdCobranca", historico.IdCobranca);

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static int DeleteHistorico(int idHistorico)
        {
            int ret = 0;
            string sql = "DELETE FROM HISTORICO WHERE ID = @IdHistorico)";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@IdHistorico", idHistorico);

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        internal static List<Historico> GetHistoricoList(int idCobranca)
        {
            List<Historico> ret = new List<Historico>();
            SQLiteDataAdapter da = null;

            string sql = "SELECT * FROM HISTORICO WHERE IDCOBRANCA = @IdCobranca";

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@IdCobranca", idCobranca);
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    using (IDataReader rdr = cmd.ExecuteReader())
                    {
                        ret = popularHistoricos(rdr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        private static List<Historico> popularHistoricos(IDataReader rdr)
        {
            var ret = new List<Historico>();

            while (rdr.Read())
            {
                Historico p = new Historico();
                p.Id = rdr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["Id"]);
                p.Data = rdr["Data"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rdr["Data"]);
                p.Evento = rdr["Evento"] == DBNull.Value ? string.Empty : rdr["Evento"].ToString(); ;
                p.Descricao = rdr["Descricao"] == DBNull.Value ? string.Empty : rdr["Descricao"].ToString();

                ret.Add(p);
            }

            return ret;
        }
    }


}

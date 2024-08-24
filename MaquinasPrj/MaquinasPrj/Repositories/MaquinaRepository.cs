using MaquinasPrj.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasPrj.Repositories
{
    public class MaquinaRepository
    {
        private readonly SQLiteConnection _connection;

        public MaquinaRepository(DbConnection connection)
        {
            _connection = connection.connetion;
        }
        public void AddMaquina(Maquina maquina) {
            string query = "INSERT INTO MAQUINA(NOME, DESCRICAO, FABRICANTE, DATA_AQUISICAO, SETORID) VALUES (@Nome, @Descricao, @Fabricante, @Data_aquisicao, @SetorId)";
            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Nome", maquina.Nome);
                command.Parameters.AddWithValue("@Descricao", maquina.Descricao);
                command.Parameters.AddWithValue("@Fabricante", maquina.Fabricante);
                command.Parameters.AddWithValue("@Data_aquisicao", maquina.DataAquisicao);
                command.Parameters.AddWithValue("@SetorId", maquina.SetorId);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateMaquina(Maquina maquina) {
            string query = "UPDATE MAQUINA SET NOME = @Nome, DESCRICAO= @Descricao, FABRICANTE= @Fabricante, DATA_AQUISICAO = @Data_aquisicao, SETORID = @SetorId WHERE MAQUINAID = @Id";
            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", maquina.MaquinaId);
                command.Parameters.AddWithValue("@Nome", maquina.Nome);
                command.Parameters.AddWithValue("@Descricao", maquina.Descricao);
                command.Parameters.AddWithValue("@Fabricante", maquina.Fabricante);
                command.Parameters.AddWithValue("@Data_aquisicao", maquina.DataAquisicao);
                command.Parameters.AddWithValue("@SetorId", maquina.SetorId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMaquina(int id) {
            string query = "DELETE FROM MAQUINA WHERE MAQUINAID = @Id";
            using (var command = new SQLiteCommand(@query, _connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
        public List<Maquina> BuscaMaquinas() {
            var maquinas = new List<Maquina>();
            string query = "SELECT * FROM MAQUINA";
            using (var command = new SQLiteCommand(query, _connection))
            {
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { Setor setor;
                        string querys = "SELECT * FROM SETOR WHERE SETORID = @Id";
                        using (var commands = new SQLiteCommand(query, _connection))
                        {
                            commands.Parameters.AddWithValue("@Id", Convert.ToInt32(reader["maquinaid"].ToString()));
                            using (var readers = commands.ExecuteReader())
                            {
                                readers.Read();
                                setor = new Setor(Convert.ToInt32(reader["setorid"]),
                              reader["nome"].ToString());

                            }
                        }
                            var maquina = new Maquina(
                             Convert.ToInt32(reader["maquinaid"].ToString()),
                             reader["nome"].ToString(),
                             reader["descricao"].ToString(),
                             reader["fabricante"].ToString(),
                             reader["data_aquisicao"].ToString(),
                             Convert.ToInt32(reader["setorid"].ToString()),
                             setor
                             
                            );
                        maquinas.Add(maquina);
                    }
                }
            }
            
            return maquinas; }
        public Maquina BuscaMaquina(int id) {
            Maquina maquina;
            string query = "SELECT * FROM MAQUINA WHERE MAQUINAID = @Id";
            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                        Setor setor;
                        string querys = "SELECT * FROM SETOR WHERE SETORID = @Id";
                    using (var commands = new SQLiteCommand(query, _connection))
                    {
                        commands.Parameters.AddWithValue("@Id", Convert.ToInt32(reader["maquinaid"].ToString()));
                        using (var readers = commands.ExecuteReader())
                        {
                            readers.Read();
                            setor = new Setor(Convert.ToInt32(reader["setorid"]),
                          reader["nome"].ToString());

                        }
                    }

                            maquina = new Maquina(
                             Convert.ToInt32(reader["maquinaid"].ToString()),
                             reader["nome"].ToString(),
                             reader["descricao"].ToString(),
                             reader["fabricante"].ToString(),
                             reader["data_aquisicao"].ToString(),
                             Convert.ToInt32(reader["setorid"].ToString()),
                             setor
                            );
                    
                }
            }

            return maquina;
        }
    }
}

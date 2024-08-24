using MaquinasPrj.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasPrj.Repositories
{
    public class SetorRepositorie
    {
        private readonly SQLiteConnection _connection;

        public SetorRepositorie(DbConnection connection)
        {
            _connection = connection.connetion;
        }

        public void AddSetor(Setor setor)
        {
            string query = "INSERT INTO SETOR (nome) VALUES (@Nome)";

            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Nome", setor.Nome);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateSetor(Setor setor)
        {
            string query = "UPDATE SETOR SET NOME = @Nome WHERE SETORID = @Id";

            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Nome", setor.Nome);
                command.Parameters.AddWithValue("@Id", setor.SetorId);
                command.ExecuteNonQuery();
            }

        }
        public void DeleteSetor(int id)
        {
            string query = "DELETE FROM SETOR WHERE SETORID =@Id";

            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }

        }
        public List<Setor> BuscaSetores()
        {
            var setores = new List<Setor>();
            string query = "SELECT * FROM SETOR";
            using (var command = new SQLiteCommand(query, _connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Setor setor = new Setor(
                             Convert.ToInt32(reader["setorid"]),
                             reader["nome"].ToString()
                            );
                        setores.Add(setor);
                    }
                }

            }
            return setores;
        }
        public Setor BuscaSetor(int id)
        {
            Setor setor;
            string query = "SELECT * FROM SETOR WHERE SETORID = @Id";
            using (var command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    setor = new Setor(Convert.ToInt32(reader["setorid"]),
                    reader["nome"].ToString());
                    
                }
            }
            return setor;

            
        }
    }
}

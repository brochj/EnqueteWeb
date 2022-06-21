using System.Collections.Generic;

namespace EnqueteWeb.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }

        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta()
            {
                Nome = "Fulano1",
                Email = "fulando1@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Fulano2",
                Email = "fulando2@gmail.com",
                Sim = false
            });
            respostas.Add(new Resposta()
            {
                Nome = "Fulano3",
                Email = "fulando3@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Fulano4",
                Email = "fulando4@gmail.com",
                Sim = false
            });
            respostas.Add(new Resposta()
            {
                Nome = "Fulano5",
                Email = "fulando5@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Fulano6",
                Email = "fulando6@gmail.com",
                Sim = true
            });
        }

    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCadastro.Data;
using System;
using System.Linq;

namespace MvcCadastro.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCadastroContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCadastroContext>>()))
            {
                // Look for any cadastro.
                if (context.Cadastro.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cadastro.AddRange(
                    new Cadastro
                    {
                        Nome = "Lionel Andrés Messi Cuccittini",
                        Email = "lionelmessi@gmail.com",
                        RG = "22.222.222-2",
                    },

                    new Cadastro
                    {
                        Nome = "Cristiano Ronaldo dos Santos Aveiro",
                        Email = "cristianoronaldo@outlook.com",
                        RG = "55.555.555-5",
                    },

                    new Cadastro
                    {
                        Nome = "Erling Braut Håland",
                        Email = "erlinghåland@gmail.com",
                        RG = "77.777.777-7",
                    },

                    new Cadastro
                    {
                        Nome = "Anssumane Fati Vieira",
                        Email = "ansufati@outlook.com",
                        RG = "99.999.999-9",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
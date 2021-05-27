using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorData.ConsoleApp
{
    public class Converte
    {
        List<string> adicionarioNumeros = new List<string>
            {
               "Um","Dois","Três","Quatro","Cinco","Seis","Sete","Oito","Nove","Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis",
               "Dezessete","Dezoito","Dezenove","Vinte","Vinte e um","Vinte e dois","Vinte e três","Vinte e quatro","Vinte e cinco","Vinte e Seis",
               "Vinte e oito","Vinte e nove","Trinta","Trinta e um","Trinta e dois","Trinta e tres","Trinta e quatro", "Trinta e cinco", "Trinta e seis",
               "Trinta e sete", "Trinta e oito", "Trinta e nove","Quarenta","Quarenta e um","Quarenta e dois","Quarenta e três","Quarenta e quatro","Quarenta e cinco",
               "Quarenta e seis","Quarenta e sete","Quarenta e oito","Quarenta e nove","Cinquenta","Cinquenta e um","Cinquenta e dois","Cinquenta e três",
               "Cinquenta e quatro","Cinquenta e cinco","Cinquenta e seis","Cinquenta e sete","Cinquenta e oito","Cinquenta e nove","Sessenta","Sessenta e um",
               "Sessenta e dois","Sessenta e três","Sessenta e quatro","Sessenta e cinco","Sessenta e seis","Sessenta e sete","Sessenta e oito","Sessenta e nove",
               "Setenta","Sententa e um","Sententa e dois","Sententa e três","Sententa e quatro","Setenta e cinco","Setenta e seis","Setenta e sete","Sententa e oito","Setenta e nove",
               "Oitenta","Oitenta e um","Oitenta e dois","Oitenta e três","Oitenta e quatro","Oitenta e cinco","Oitenta e seis","Oitenta e sete","Oitenta e oito","Oitenta e nove",
               "Noventa","Noventa e um","Noventa e dois","Noventa e três","Noventa e quatro","Noventa e cinco","Noventa e seis","Noventa e sete","Noventa e oito","Noventa e nove"

            };
        DateTime dataCompara = new DateTime(2021, 05, 26, 15, 35, 20);
        int calculaSegundos = 0;

        string resultadoConsulta = string.Empty;
        string dezena = string.Empty;

        public string ValidarData(DateTime data)
        {
            if (data > DateTime.Now)
            {
                return "Data Invalida";
            }
            if (data.Day == dataCompara.Day && data.Month == dataCompara.Month && data.Year == dataCompara.Year)
            {
                if (data.Second != dataCompara.Second && data.Minute == dataCompara.Minute && data.Hour == dataCompara.Hour)
                {

                    calculaSegundos = dataCompara.Second - data.Second;


                    for (int i = 0; i < adicionarioNumeros.Count; i++)
                    {
                        if (calculaSegundos == i && calculaSegundos != 1)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " segundos atras";
                        }
                        else if (calculaSegundos == 1)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " segundo atras";
                        }

                    }
                }
                else if (data.Hour == dataCompara.Hour && data.Minute != dataCompara.Minute)
                {
                    int calculoMinutos = dataCompara.Minute - data.Minute;

                    for (int i = 0; i < adicionarioNumeros.Count; i++)
                    {
                        if (calculoMinutos == i && calculaSegundos != 1)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " minutos atras";
                        }
                        else if (calculoMinutos == 1)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " minuto atras";
                        }

                    }
                }
                else if (data.Hour != dataCompara.Hour)
                {
                    int calculoHoras = dataCompara.Hour - data.Hour;

                    for (int i = 0; i < adicionarioNumeros.Count; i++)
                    {
                        if (calculoHoras == i && calculoHoras != 1)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " horas atras";
                        }
                        else if (calculoHoras == 1)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " hora atras";
                        }
                    }
                }
            }
            return "numeros";
        }
        public string validaDias(DateTime data)
        {
            int calculoDias = dataCompara.Day - data.Day;

            if (data.Day < dataCompara.Day && data.Month == dataCompara.Month && data.Year == dataCompara.Year && calculoDias < 7)
            {
                for (int i = 0; i < adicionarioNumeros.Count; i++)
                {
                    if (calculoDias == i && calculoDias != 1)
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " dias atras";

                    }
                    else if (calculoDias == 1 && calculoDias == i)
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " dia atras";
                    }
                }
            }
            else if (calculoDias >= 7)
            {
                int calculoSemanas = calculoDias / 7;

                for (int i = 0; i < adicionarioNumeros.Count; i++)
                {
                    if (calculoSemanas == i && calculoSemanas != 1)
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " semanas atras";
                    }
                    else if (calculoSemanas == i && calculoSemanas == 1)
                    {
                        return resultadoConsulta  = adicionarioNumeros[i - 1] + " semana atras";
                    }
                }
            }
            return resultadoConsulta = "0";
        }
        public string ValidaMes(DateTime data)
        {
            string recebeDias = validaDias(data);
            int calculoMes = dataCompara.Month - data.Month;
            if (data.Month != dataCompara.Month && data.Year == dataCompara.Year)
            {
                for (int i = 0; i < adicionarioNumeros.Count; i++)
                {
                    if (calculoMes == i && calculoMes != 1 && recebeDias == "0")
                    {
                        return resultadoConsulta  = adicionarioNumeros[i - 1] + " meses atras";
                    }
                    else if (calculoMes == 1 && calculoMes == i && recebeDias == "0")
                    {
                        return resultadoConsulta  = adicionarioNumeros[i - 1] + " mes atras";
                    }
                    else if (calculoMes == i && calculoMes != 1 && recebeDias != "0")
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " meses e " + recebeDias.ToLower();

                    }
                    else if (calculoMes == i && calculoMes == 1 && recebeDias != "0")
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " mes e " + recebeDias.ToLower();
                    }
                }
            }
            else if (data.Year != dataCompara.Year)
            {
                int subDataRecebida = 12 - data.Month;
                int adMeses = subDataRecebida + dataCompara.Month;
                int divideMeses = adMeses % 12;

                if (divideMeses != 0)
                {

                    for (int i = 0; i < adicionarioNumeros.Count; i++)
                    {
                        if (divideMeses == i && divideMeses != 1 && divideMeses != 0)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " meses atras";
                        }
                        else if (divideMeses == 1 && divideMeses == i && divideMeses != 0)
                        {
                            return resultadoConsulta = adicionarioNumeros[i - 1] + " mes atras";
                        }
                    }
                }
                else
                {
                    return resultadoConsulta = "0";
                }

            }

                return resultadoConsulta;
        }
        public string validadeAno(DateTime data)
        {

            string recebeConsulta = ValidaMes(data);

            if (data.Year != dataCompara.Year)
            {
                int calculoAno = dataCompara.Year - data.Year;
                for (int i = 0; i < adicionarioNumeros.Count; i++)
                {

                    if (calculoAno == i && calculoAno != 1 && recebeConsulta != "0")
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " anos e" + recebeConsulta.ToLower();
                    }
                    else if (calculoAno == 1 && calculoAno == i && recebeConsulta != "0")
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " ano e " + recebeConsulta.ToLower();
                    }
                    else if (calculoAno == 1 && calculoAno == i && recebeConsulta == "0")
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " ano atras";

                    }
                    else if (calculoAno == i && calculoAno == i && recebeConsulta == "0")
                    {
                        return resultadoConsulta = adicionarioNumeros[i - 1] + " anos atras";
                    }
                }
            }

            return resultadoConsulta;
        }
 
    }
}

﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


//using windows.web.http;

namespace onlineTroll
{

    //class Interprete
    //{
    //    public Interprete()
    //    {
    //    }
    //};

    class Compilador
    {
        /*public async Task LOL()
        {
            var conexion = new HttpClient();
            conexion.DefaultRequestHeaders.Add("Authorization", "suidhsadddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
            var pagina = await conexion.GetAsync("https://olive-pet.glitch.me/");
            //pagina.EnsureSuccessStatusCode();
            var html = await pagina.Content.ReadAsStringAsync();
            var status = pagina.StatusCode.ToString();
            Console.WriteLine(status);
            Console.WriteLine(html);
        }*/
        public async Task SCompilador(string codigo)
        {

            try
            {
                Console.Clear();
                string codigosintitulo = string.Empty;
                if (codigo.StartsWith("<"))
                {
                    var nombre = codigo.Split('>')[0].Substring(1);
                    Console.Title = nombre;

                    var divicion = codigo.Split('>');

                    for (var xq = 0; xq < divicion.Length; xq++)
                    {
                        if (xq == 0)
                        {
                        }
                        else if (xq == divicion.Length - 1)
                        {
                            codigosintitulo = codigosintitulo + divicion[xq];
                        }
                        else
                        {
                            codigosintitulo = codigosintitulo + divicion[xq] + ">";
                        };
                    };
                }
                else
                {

                    codigosintitulo = codigo;
                }
                String[] diviciondecodigo = codigosintitulo.Split('\n');

                string a = string.Empty;
                string b = string.Empty;
                string c = string.Empty;
                string d = string.Empty;
                string e = string.Empty;
                string f = string.Empty;
                string g = string.Empty;
                string h = string.Empty;
                string i = string.Empty;
                string j = string.Empty;

                Double k = 0;
                Double l = 0;
                Double m = 0;
                Double n = 0;
                Double ñ = 0;
                Double o = 0;
                Double p = 0;
                Double q = 0;
                Double r = 0;
                Double s = 0;

                Double[] t = new Double[99999999];
                string[] u = new string[99999999];
                bool[] v = new bool[99999999];

                bool w = false;
                bool x = false;
                bool y = false;
                bool z = false;

                /*bool buscarBool()
                {

                };

                string buscarTxt()
                {

                };

                Double buscarNumero()
                {

                };*/

                var cambiarvalor = new Regex(".+¨ç].+");
                var laif = new Regex(".¿!ª#.");
                var http = new Regex("^l},º.<.¿.+¿.+¿.+");
                var archivus = new Regex("^♫↕!.+csis.");
                var consola = new Regex("^↓ùp👌.");
                var bucle = new Regex("__rap.");
                var salir = new Regex("&{-");
                var sleep = new Regex("çlbv.");
                var invertirbool = new Regex("!7;.");
                var sumedore = new Regex(".__DPR.+");
                var restare = new Regex(".__RPD.+");
                var consolaentrada = new Regex(".👉👌");
                var remplazar = new Regex("¨#__._.+_._.");
                var match = new Regex("__kp.+_._.");
                var editarchivus = new Regex(".+👌👈.");
                var concact = new Regex("-/aa.#.#.");
                var controldetamaño = new Regex("gg.¿.¿.¿.");
                var intparse = new Regex("☺.♥☻.");
                var reset = new Regex("ñpqq.");
                var exec = new Regex("yyyy.+@.+@.");


                for (var xxx = 0; xxx < diviciondecodigo.Length; xxx++)
                {


if (laif.IsMatch(diviciondecodigo[xxx]))
                    {
                        var arrayasignacion = diviciondecodigo[xxx].Replace("¿!ª#", "�").Split('�');
                        /*string aa;
                        Double ab;
                        bool ac;
                        string ba;
                        Double bb;
                        bool bc;*/
                        string suno = null;
                        Double funo = Double.NaN;
                        string sdos = null;
                        Double fdos = Double.NaN;
                        //Console.WriteLine(Eval.Execute<String>("a"), new { a = a });
                        switch (arrayasignacion[0])
                        {
                            case "a":
                                suno = a;
                                break;
                            case "b":
                                suno = b;
                                break;
                            case "c":
                                suno = c;
                                break;
                            case "d":
                                suno = d;
                                break;
                            case "e":
                                suno = e;
                                break;
                            case "f":
                                suno = f;
                                break;
                            case "g":
                                suno = g;
                                break;
                            case "h":
                                suno = h;
                                break;
                            case "i":
                                suno = i;
                                break;
                            case "j":
                                suno = j;
                                break;
                        };

                        switch (arrayasignacion[0])
                        {
                            case "k":
                                funo = k;
                                break;
                            case "l":
                                funo = l;
                                break;
                            case "m":
                                funo = m;
                                break;
                            case "n":
                                funo = n;
                                break;
                            case "ñ":
                                funo = ñ;
                                break;
                            case "o":
                                funo = o;
                                break;
                            case "p":
                                funo = p;
                                break;
                            case "q":
                                funo = q;
                                break;
                            case "r":
                                funo = r;
                                break;
                            case "s":
                                funo = s;
                                break;
                        };
                        if (arrayasignacion[1][0].ToString().Contains("a"))
                        {
                            sdos = a;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("b"))
                        {
                            sdos = b;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("c"))
                        {
                            sdos = c;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("d"))
                        {
                            sdos = d;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("e"))
                        {
                            sdos = e;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("f"))
                        {
                            sdos = f;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("g"))
                        {
                            sdos = g;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("h"))
                        {
                            sdos = h;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("i"))
                        {
                            sdos = i;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("j"))
                        {
                            sdos = j;
                        };

                        if (arrayasignacion[1][0].ToString().Contains("k"))
                        {
                            fdos = k;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("l"))
                        {
                            fdos = l;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("m"))
                        {
                            fdos = m;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("n"))
                        {
                            fdos = n;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("ñ"))
                        {
                            fdos = ñ;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("o"))
                        {
                            fdos = o;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("p"))
                        {
                            fdos = p;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("q"))
                        {
                            fdos = q;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("r"))
                        {
                            fdos = r;
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("s"))
                        {
                            fdos = s;
                        };





                        //if (suno != null) { } else if (funo != Double.NaN) { } else { };
                        if (suno != null && sdos != null)
                        {
                            if (suno == sdos)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "�").Split('�');
for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++) {
    if (consola.IsMatch(nuevocodigo[controladordenuevo])) {
        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
        //Console.WriteLine(variablus.Length);
        if (variablus[0].ToString().Contains("a")) {
            Console.WriteLine(a);
        }
        else if (variablus[0].ToString().Contains("b")) {
            Console.WriteLine(b);
        }
        else if (variablus[0].ToString().Contains("c")) {
            Console.WriteLine(c);
        }
        else if (variablus[0].ToString().Contains("d")) {
            Console.WriteLine(d);
        }
        else if (variablus[0].ToString().Contains("e")) {
            Console.WriteLine(e);
        }
        else if (variablus[0].ToString().Contains("f")) {
            Console.WriteLine(f);
        }
        else if (variablus[0].ToString().Contains("g")) {
            Console.WriteLine(g);
        }
        else if (variablus[0].ToString().Contains("h")) {
            Console.WriteLine(h);
        }
        else if (variablus[0].ToString().Contains("i")) {
            Console.WriteLine(i);
        }
        else if (variablus[0].ToString().Contains("j")) {
            Console.WriteLine(j);
        }
        else if (variablus[0].ToString().Contains("k")) {
            Console.WriteLine(k);
        }
        else if (variablus[0].ToString().Contains("l")) {
            Console.WriteLine(l);
        }
        else if (variablus[0].ToString().Contains("m")) {
            Console.WriteLine(m);
        }
        else if (variablus[0].ToString().Contains("n")) {
            Console.WriteLine(n);
        }
        else if (variablus[0].ToString().Contains("ñ")) {
            Console.WriteLine(ñ);
        }
        else if (variablus[0].ToString().Contains("o")) {
            Console.WriteLine(o);
        }
        else if (variablus[0].ToString().Contains("p")) {
            Console.WriteLine(p);
        }
        else if (variablus[0].ToString().Contains("q")) {
            Console.WriteLine(q);
        }
        else if (variablus[0].ToString().Contains("r")) {
            Console.WriteLine(r);
        }
        else if (variablus[0].ToString().Contains("s")) {
            Console.WriteLine(s);
        }
        else if (variablus[0].ToString().Contains("t")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            //Console.WriteLine(variablus[1]);
            var consolear = t[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("u")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = u[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("v")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = v[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("w")) {
            Console.WriteLine(w);
        }
        else if (variablus[0].ToString().Contains("x")) {
            Console.WriteLine(x);
        }
        else if (variablus[0].ToString().Contains("y")) {
            Console.WriteLine(y);
        }
        else if (variablus[0].ToString().Contains("z")) {
            Console.WriteLine(z);
        }
        else {
            throw new Exception();
        };
    }
    else if (archivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "�").Split('�');
        if (File.Exists(divicionenaccion[0].Substring(3))) {
            var txt = File.ReadAllText(divicionenaccion[0].Substring(3));
            if (divicionenaccion[1].ToString().Contains("a")) {
                a = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("b")) {
                b = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("c")) {
                c = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("d")) {
                d = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("e")) {
                e = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("f")) {
                f = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("g")) {
                g = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("h")) {
                h = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("i")) {
                i = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("j")) {
                j = txt;
            }
            else {
                throw new Exception();
            };
        }
        else {
            //Console.WriteLine(divicionenaccion[0]);
            throw new Exception();
        };
    }
    else if (http.IsMatch(nuevocodigo[controladordenuevo])) {
        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
        if (link.Length == 1) {
            if (link[0].ToString().Contains("a")) {
                link = a;
            }
            else if (link[0].ToString().Contains("b")) {
                link = b;
            }
            else if (link[0].ToString().Contains("c")) {
                link = c;
            }
            else if (link[0].ToString().Contains("d")) {
                link = d;
            }
            else if (link[0].ToString().Contains("e")) {
                link = e;
            }
            else if (link[0].ToString().Contains("f")) {
                link = f;
            }
            else if (link[0].ToString().Contains("g")) {
                link = g;
            }
            else if (link[0].ToString().Contains("h")) {
                link = h;
            }
            else if (link[0].ToString().Contains("i")) {
                link = i;
            }
            else if (link[0].ToString().Contains("j")) {
                link = j;
            };
        };
        var conexion = new HttpClient();
        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
        //conexion.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
        HttpResponseMessage pagina;
        if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("get")) {
            pagina = await conexion.GetAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("delete")) {
            pagina = await conexion.DeleteAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("post")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Post;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("put")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Put;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else {
            throw new Exception();
            //pagina = await conexion.PutAsync(new Uri(link), new StringContent(nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1]));
        };
        var html = await pagina.Content.ReadAsStringAsync();
        var status1 = pagina.StatusCode.ToString();
        Double status;
        switch (status1) {
            case "Accepted":
                status = 202;
                break;
            case "Ambiguous":
                status = 300;
                break;
            case "BadGateway":
                status = 502;
                break;
            case "BadRequest":
                status = 400;
                break;
            case "Conflict":
                status = 409;
                break;
            case "Continue":
                status = 100;
                break;
            case "Created":
                status = 201;
                break;
            case "ExpectationFailed":
                status = 417;
                break;
            case "Forbidden":
                status = 403;
                break;
            case "Found":
                status = 302;
                break;
            case "GatewayTimeout":
                status = 504;
                break;
            case "Gone":
                status = 410;
                break;
            case "HttpVersionNotSupported":
                status = 505;
                break;
            case "InternalServerError":
                status = 500;
                break;
            case "LengthRequired":
                status = 411;
                break;
            case "MethodNotAllowed":
                status = 405;
                break;
            case "Moved":
                status = 301;
                break;
            case "MovedPermanently":
                status = 301;
                break;
            case "MultipleChoices":
                status = 300;
                break;
            case "NoContent":
                status = 204;
                break;
            case "NonAuthoritativeInformation":
                status = 203;
                break;
            case "NotAcceptable":
                status = 406;
                break;
            case "NotFound":
                status = 404;
                break;
            case "NotImplemented":
                status = 501;
                break;
            case "NotModified":
                status = 304;
                break;
            case "OK":
                status = 200;
                break;
            case "PartialContent":
                status = 206;
                break;
            case "PaymentRequired":
                status = 402;
                break;
            case "PreconditionFailed":
                status = 412;
                break;
            case "ProxyAuthenticationRequired":
                status = 407;
                break;
            case "Redirect":
                status = 302;
                break;
            case "RedirectKeepVerb":
                status = 307;
                break;
            case "RedirectMethod":
                status = 303;
                break;
            case "RequestedRangeNotSatisfiable":
                status = 416;
                break;
            case "RequestEntityTooLarge":
                status = 413;
                break;
            case "RequestTimeout":
                status = 408;
                break;
            case "RequestUriTooLong":
                status = 414;
                break;
            case "ResetContent":
                status = 205;
                break;
            case "SeeOther":
                status = 303;
                break;
            case "ServiceUnavailable":
                status = 503;
                break;
            case "SwitchingProtocols":
                status = 101;
                break;
            case "TemporaryRedirect":
                status = 307;
                break;
            case "Unauthorized":
                status = 401;
                break;
            case "UnsupportedMediaType":
                status = 415;
                break;
            case "Unused":
                status = 306;
                break;
            case "UpgradeRequired":
                status = 426;
                break;
            case "UseProxy":
                status = 305;
                break;
            default:
                throw new Exception();
                break;
        };
        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
        switch (varparaelstatus) {
            case "k":
                k = status;
                break;
            case "l":
                l = status;
                break;
            case "m":
                m = status;
                break;
            case "n":
                n = status;
                break;
            case "ñ":
                ñ = status;
                break;
            case "o":
                o = status;
                break;
            case "p":
                p = status;
                break;
            case "q":
                q = status;
                break;
            case "r":
                r = status;
                break;
            case "s":
                s = status;
                break;
            default:
                throw new Exception();
                break;
        };
        switch (varparalapagina) {
            case "a":
                a = html;
                break;
            case "b":
                a = html;
                break;
            case "c":
                a = html;
                break;
            case "d":
                a = html;
                break;
            case "e":
                a = html;
                break;
            case "f":
                a = html;
                break;
            case "g":
                a = html;
                break;
            case "h":
                a = html;
                break;
            case "i":
                a = html;
                break;
            case "j":
                a = html;
                break;
            default:
                throw new Exception();
                break;
        };

    }
    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo])) {



        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "�").Split('�');
        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

        ///////////////////////////////////////////
        //Console.WriteLine(arrayasignacionif[1].Length);
        var estoesarray = new Regex(".-_-.");
        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
        {
            throw new Exception();
        }*/
        if (arrayasignacionif[1][0].ToString().Contains("a")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    a = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                a = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("b")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    b = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                b = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("c")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    c = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                c = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("d")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    d = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                d = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("e")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    e = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                e = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("f")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    f = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                f = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("g")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    g = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                g = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("h")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    h = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                h = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("i")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    i = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                i = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("j")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    j = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                j = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
        {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    k = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                k = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("l")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    l = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                l = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("m")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    m = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                m = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("n")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    n = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                n = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("ñ")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    ñ = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                ñ = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("o")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    o = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                o = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("p")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    p = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                p = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("q")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    q = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                q = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("r")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    r = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                r = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("s")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    s = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                s = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("t")) {
            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion.Length; zzz++) {
                if (jajadivicion[zzz].Contains("NaN")) {
                    throw new Exception();
                }
                t[zzz] = Double.Parse(jajadivicion[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("u")) {
            u = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
        }
        else if (arrayasignacionif[1][0].ToString().Contains("v")) {
            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++) {
                v[zzz] = bool.Parse(jajadivicion2[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("w")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    w = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                w = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("x")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    x = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                x = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("y")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    y = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                y = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("z")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    z = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                z = bool.Parse(arrayasignacionif[0]);
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (salir.IsMatch(nuevocodigo[controladordenuevo])) {
        Environment.Exit(69);
    }
    else if (sleep.IsMatch(nuevocodigo[controladordenuevo])) {
        var varibleabuscar = nuevocodigo[controladordenuevo].Replace("çlbv", "");

        if (varibleabuscar[0].ToString().Contains("k")) {
            Thread.Sleep(int.Parse(k.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("l")) {
            Thread.Sleep(int.Parse(l.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("m")) {
            Thread.Sleep(int.Parse(m.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("n")) {
            Thread.Sleep(int.Parse(n.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("ñ")) {
            Thread.Sleep(int.Parse(ñ.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("o")) {
            Thread.Sleep(int.Parse(o.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("p")) {
            Thread.Sleep(int.Parse(p.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("q")) {
            Thread.Sleep(int.Parse(q.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("r")) {
            Thread.Sleep(int.Parse(r.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("s")) {
            Thread.Sleep(int.Parse(s.ToString()));
        }
        else {
            throw new Exception();
        };
    }
    else if (invertirbool.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableainvertir = nuevocodigo[controladordenuevo].Replace("!7;", "");
        if (variableainvertir[0].ToString().Contains("w")) {
            w = !w;
        }
        else if (variableainvertir[0].ToString().Contains("x")) {
            x = !x;
        }
        else if (variableainvertir[0].ToString().Contains("y")) {
            y = !y;
        }
        else if (variableainvertir[0].ToString().Contains("z")) {
            z = !z;
        }
        else {
            throw new Exception();
        };
    }
    else if (restare.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s - numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (sumedore.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s + numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (consolaentrada.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparalacomprobacion = nuevocodigo[controladordenuevo][0];
        if (variableparalacomprobacion.ToString().Contains("a")) {
            a = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("b")) {
            b = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("c")) {
            c = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("d")) {
            d = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("e")) {
            e = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("f")) {
            f = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("g")) {
            g = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("h")) {
            h = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("i")) {
            i = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("j")) {
            j = Console.ReadLine();
        }
        else {
            throw new Exception();
        };
    }
    else if (remplazar.IsMatch(nuevocodigo[controladordenuevo])) {
        var argumentos = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        string texto;
        string remplazo;
        var exp = new Regex(argumentos[1]);
        if (argumentos[0][0].ToString().Contains("a")) {
            texto = a;
        }
        else if (argumentos[0][0].ToString().Contains("b")) {
            texto = b;
        }
        else if (argumentos[0][0].ToString().Contains("c")) {
            texto = c;
        }
        else if (argumentos[0][0].ToString().Contains("d")) {
            texto = d;
        }
        else if (argumentos[0][0].ToString().Contains("e")) {
            texto = e;
        }
        else if (argumentos[0][0].ToString().Contains("f")) {
            texto = f;
        }
        else if (argumentos[0][0].ToString().Contains("g")) {
            texto = g;
        }
        else if (argumentos[0][0].ToString().Contains("h")) {
            texto = h;
        }
        else if (argumentos[0][0].ToString().Contains("i")) {
            texto = i;
        }
        else if (argumentos[0][0].ToString().Contains("j")) {
            texto = j;
        }
        else {
            throw new Exception();
        };


        if (argumentos[2][0].ToString().Contains("a")) {
            remplazo = a;
        }
        else if (argumentos[2][0].ToString().Contains("b")) {
            remplazo = b;
        }
        else if (argumentos[2][0].ToString().Contains("c")) {
            remplazo = c;
        }
        else if (argumentos[2][0].ToString().Contains("d")) {
            remplazo = d;
        }
        else if (argumentos[2][0].ToString().Contains("e")) {
            remplazo = e;
        }
        else if (argumentos[2][0].ToString().Contains("f")) {
            remplazo = f;
        }
        else if (argumentos[2][0].ToString().Contains("g")) {
            remplazo = g;
        }
        else if (argumentos[2][0].ToString().Contains("h")) {
            remplazo = h;
        }
        else if (argumentos[2][0].ToString().Contains("i")) {
            remplazo = i;
        }
        else if (argumentos[2][0].ToString().Contains("j")) {
            remplazo = j;
        }
        else {
            throw new Exception();
        };

        var resultado = exp.Replace(texto, remplazo);

        if (argumentos[3][0].ToString().Contains("a")) {
            a = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("b")) {
            b = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("c")) {
            c = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("d")) {
            d = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("e")) {
            e = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("f")) {
            f = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("g")) {
            g = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("h")) {
            h = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("i")) {
            i = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("j")) {
            j = resultado;
        }
        else {
            throw new Exception();
        };

    }//
    else if (match.IsMatch(nuevocodigo[controladordenuevo])) {
        var args = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        var expjaja = new Regex(args[0]);
        bool ismatch;

        if (args[1][0].ToString().Contains("a")) {
            if (expjaja.IsMatch(a)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("b")) {
            if (expjaja.IsMatch(b)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("c")) {
            if (expjaja.IsMatch(c)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("d")) {
            if (expjaja.IsMatch(d)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("e")) {
            if (expjaja.IsMatch(e)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("f")) {
            if (expjaja.IsMatch(f)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("g")) {
            if (expjaja.IsMatch(g)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("h")) {
            if (expjaja.IsMatch(h)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("i")) {
            if (expjaja.IsMatch(i)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("j")) {
            if (expjaja.IsMatch(j)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else {
            throw new Exception();
        };

        if (args[2][0].ToString().Contains("w")) {
            w = ismatch;
        }
        else if (args[2][0].ToString().Contains("x")) {
            x = ismatch;
        }
        else if (args[2][0].ToString().Contains("y")) {
            y = ismatch;
        }
        else if (args[2][0].ToString().Contains("z")) {
            z = ismatch;
        }
        else {
            throw new Exception();
        };

    }////////////////
    else if (editarchivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var arrayedit = nuevocodigo[controladordenuevo].Replace("👌👈", "�").Split('�');
        if (File.Exists(arrayedit[0])) {
            if (arrayedit[1][0].ToString().Contains("a")) {
                File.WriteAllText(arrayedit[0], a);
            }
            else if (arrayedit[1][0].ToString().Contains("b")) {
                File.WriteAllText(arrayedit[0], b);
            }
            else if (arrayedit[1][0].ToString().Contains("c")) {
                File.WriteAllText(arrayedit[0], c);
            }
            else if (arrayedit[1][0].ToString().Contains("d")) {
                File.WriteAllText(arrayedit[0], d);
            }
            else if (arrayedit[1][0].ToString().Contains("e")) {
                File.WriteAllText(arrayedit[0], e);
            }
            else if (arrayedit[1][0].ToString().Contains("f")) {
                File.WriteAllText(arrayedit[0], f);
            }
            else if (arrayedit[1][0].ToString().Contains("g")) {
                File.WriteAllText(arrayedit[0], g);
            }
            else if (arrayedit[1][0].ToString().Contains("h")) {
                File.WriteAllText(arrayedit[0], h);
            }
            else if (arrayedit[1][0].ToString().Contains("i")) {
                File.WriteAllText(arrayedit[0], i);
            }
            else if (arrayedit[1][0].ToString().Contains("j")) {
                File.WriteAllText(arrayedit[0], j);
            }
            else {
                throw new Exception();
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (concact.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaconcact = nuevocodigo[controladordenuevo].Replace("-/aa", "").Split('#');
        string concat1;
        string concat2;
        if (divicionparaconcact[0].ToString().Contains("a")) {
            concat1 = a;
        }
        else if (divicionparaconcact[0].ToString().Contains("b")) {
            concat1 = b;
        }
        else if (divicionparaconcact[0].ToString().Contains("c")) {
            concat1 = c;
        }
        else if (divicionparaconcact[0].ToString().Contains("d")) {
            concat1 = d;
        }
        else if (divicionparaconcact[0].ToString().Contains("e")) {
            concat1 = e;
        }
        else if (divicionparaconcact[0].ToString().Contains("f")) {
            concat1 = f;
        }
        else if (divicionparaconcact[0].ToString().Contains("g")) {
            concat1 = g;
        }
        else if (divicionparaconcact[0].ToString().Contains("h")) {
            concat1 = h;
        }
        else if (divicionparaconcact[0].ToString().Contains("i")) {
            concat1 = i;
        }
        else if (divicionparaconcact[0].ToString().Contains("j")) {
            concat1 = j;
        }
        else {
            throw new Exception();
        };


        if (divicionparaconcact[1].ToString().Contains("a")) {
            concat2 = a;
        }
        else if (divicionparaconcact[1].ToString().Contains("b")) {
            concat2 = b;
        }
        else if (divicionparaconcact[1].ToString().Contains("c")) {
            concat2 = c;
        }
        else if (divicionparaconcact[1].ToString().Contains("d")) {
            concat2 = d;
        }
        else if (divicionparaconcact[1].ToString().Contains("e")) {
            concat2 = e;
        }
        else if (divicionparaconcact[1].ToString().Contains("f")) {
            concat2 = f;
        }
        else if (divicionparaconcact[1].ToString().Contains("g")) {
            concat2 = g;
        }
        else if (divicionparaconcact[1].ToString().Contains("h")) {
            concat2 = h;
        }
        else if (divicionparaconcact[1].ToString().Contains("i")) {
            concat2 = i;
        }
        else if (divicionparaconcact[1].ToString().Contains("j")) {
            concat2 = j;
        }
        else {
            throw new Exception();
        };

        var posta = concat1 + concat2;

        if (divicionparaconcact[2].ToString().Contains("a")) {
            a = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("b")) {
            b = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("c")) {
            c = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("d")) {
            d = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("e")) {
            e = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("f")) {
            f = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("g")) {
            g = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("h")) {
            h = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("i")) {
            i = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("j")) {
            j = posta;
        }
        else {
            throw new Exception();
        };

        /////////////////
    }
    else if (controldetamaño.IsMatch(nuevocodigo[controladordenuevo])) {
        var controldetamañodivicion = nuevocodigo[controladordenuevo].Replace("gg", "").Split('¿');
        string textocontrol;

        if (controldetamañodivicion[0].ToString().Contains("a")) {
            textocontrol = a;
        }
        else if (controldetamañodivicion[0].ToString().Contains("b")) {
            textocontrol = b;
        }
        else if (controldetamañodivicion[0].ToString().Contains("c")) {
            textocontrol = c;
        }
        else if (controldetamañodivicion[0].ToString().Contains("d")) {
            textocontrol = d;
        }
        else if (controldetamañodivicion[0].ToString().Contains("e")) {
            textocontrol = e;
        }
        else if (controldetamañodivicion[0].ToString().Contains("f")) {
            textocontrol = f;
        }
        else if (controldetamañodivicion[0].ToString().Contains("g")) {
            textocontrol = g;
        }
        else if (controldetamañodivicion[0].ToString().Contains("h")) {
            textocontrol = h;
        }
        else if (controldetamañodivicion[0].ToString().Contains("i")) {
            textocontrol = i;
        }
        else if (controldetamañodivicion[0].ToString().Contains("j")) {
            textocontrol = j;
        }
        else {
            throw new Exception();
        };
        double primero;
        double segundo;

        if (controldetamañodivicion[1].ToString().Contains("k")) {
            primero = k;
        }
        else if (controldetamañodivicion[1].ToString().Contains("l")) {
            primero = l;
        }
        else if (controldetamañodivicion[1].ToString().Contains("m")) {
            primero = m;
        }
        else if (controldetamañodivicion[1].ToString().Contains("n")) {
            primero = n;
        }
        else if (controldetamañodivicion[1].ToString().Contains("ñ")) {
            primero = ñ;
        }
        else if (controldetamañodivicion[1].ToString().Contains("o")) {
            primero = o;
        }
        else if (controldetamañodivicion[1].ToString().Contains("p")) {
            primero = p;
        }
        else if (controldetamañodivicion[1].ToString().Contains("q")) {
            primero = q;
        }
        else if (controldetamañodivicion[1].ToString().Contains("r")) {
            primero = r;
        }
        else if (controldetamañodivicion[1].ToString().Contains("s")) {
            primero = s;
        }
        else {
            throw new Exception();
        };

        if (controldetamañodivicion[2].ToString().Contains("k")) {
            segundo = k;
        }
        else if (controldetamañodivicion[2].ToString().Contains("l")) {
            segundo = l;
        }
        else if (controldetamañodivicion[2].ToString().Contains("m")) {
            segundo = m;
        }
        else if (controldetamañodivicion[2].ToString().Contains("n")) {
            segundo = n;
        }
        else if (controldetamañodivicion[2].ToString().Contains("ñ")) {
            segundo = ñ;
        }
        else if (controldetamañodivicion[2].ToString().Contains("o")) {
            segundo = o;
        }
        else if (controldetamañodivicion[2].ToString().Contains("p")) {
            segundo = p;
        }
        else if (controldetamañodivicion[2].ToString().Contains("q")) {
            segundo = q;
        }
        else if (controldetamañodivicion[2].ToString().Contains("r")) {
            segundo = r;
        }
        else if (controldetamañodivicion[2].ToString().Contains("s")) {
            segundo = s;
        }
        else {
            throw new Exception();
        };

        var controlado = textocontrol.Substring(int.Parse(primero.ToString()), int.Parse(segundo.ToString()));

        if (controldetamañodivicion[3][0].ToString().Contains("a")) {
            a = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("b")) {
            b = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("c")) {
            c = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("d")) {
            d = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("e")) {
            e = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("f")) {
            f = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("g")) {
            g = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("h")) {
            h = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("i")) {
            i = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("j")) {
            j = controlado;
        }
        else {
            throw new Exception();
        };

        /////////
    }
    else if (intparse.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparaint = nuevocodigo[controladordenuevo].Replace("☺", "").Replace("♥☻", "�").Split('�');
        string aint;


        if (variableparaint[0][0].ToString().Contains("a")) {
            aint = a;
        }
        else if (variableparaint[0][0].ToString().Contains("b")) {
            aint = b;
        }
        else if (variableparaint[0][0].ToString().Contains("c")) {
            aint = c;
        }
        else if (variableparaint[0][0].ToString().Contains("d")) {
            aint = d;
        }
        else if (variableparaint[0][0].ToString().Contains("e")) {
            aint = e;
        }
        else if (variableparaint[0][0].ToString().Contains("f")) {
            aint = f;
        }
        else if (variableparaint[0][0].ToString().Contains("g")) {
            aint = g;
        }
        else if (variableparaint[0][0].ToString().Contains("h")) {
            aint = h;
        }
        else if (variableparaint[0][0].ToString().Contains("i")) {
            aint = i;
        }
        else if (variableparaint[0][0].ToString().Contains("j")) {
            aint = j;
        }
        else {
            throw new Exception();
        };

        if (variableparaint[1][0].ToString().Contains("k")) {
            k = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("l")) {
            l = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("m")) {
            m = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("n")) {
            n = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("ñ")) {
            ñ = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("o")) {
            o = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("p")) {
            p = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("q")) {
            q = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("r")) {
            r = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("s")) {
            s = Double.Parse(aint);
        }
        else {
            throw new Exception();
        };
        ///////////////
    }
    else if (reset.IsMatch(nuevocodigo[controladordenuevo])) {
        var resetdivicion = nuevocodigo[controladordenuevo].Replace("ñpqq", "");

        if (resetdivicion[0].ToString().Contains("k")) {
            xxx = int.Parse(k.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("l")) {
            xxx = int.Parse(l.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("m")) {
            xxx = int.Parse(m.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("n")) {
            xxx = int.Parse(n.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("ñ")) {
            xxx = int.Parse(ñ.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("o")) {
            xxx = int.Parse(o.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("p")) {
            xxx = int.Parse(p.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("q")) {
            xxx = int.Parse(q.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("r")) {
            xxx = int.Parse(r.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("s")) {
            xxx = int.Parse(s.ToString());
        }
        else {
            throw new Exception();
        };
        //////
    }
    else if (exec.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaexec = nuevocodigo[controladordenuevo].Replace("yyyy", "").Split('@');
        string archivoexec;
        string argumentosexec;
        var proseso = new Process();
        if (divicionparaexec[0][0].ToString().Contains("a")) {
            archivoexec = a;
        }
        else if (divicionparaexec[0][0].ToString().Contains("b")) {
            archivoexec = b;
        }
        else if (divicionparaexec[0][0].ToString().Contains("c")) {
            archivoexec = c;
        }
        else if (divicionparaexec[0][0].ToString().Contains("d")) {
            archivoexec = d;
        }
        else if (divicionparaexec[0][0].ToString().Contains("e")) {
            archivoexec = e;
        }
        else if (divicionparaexec[0][0].ToString().Contains("f")) {
            archivoexec = f;
        }
        else if (divicionparaexec[0][0].ToString().Contains("g")) {
            archivoexec = g;
        }
        else if (divicionparaexec[0][0].ToString().Contains("h")) {
            archivoexec = h;
        }
        else if (divicionparaexec[0][0].ToString().Contains("i")) {
            archivoexec = i;
        }
        else if (divicionparaexec[0][0].ToString().Contains("j")) {
            archivoexec = j;
        }
        else {
            archivoexec = divicionparaexec[0];
        };

        if (divicionparaexec[1][0].ToString().Contains("a")) {
            argumentosexec = a;
        }
        else if (divicionparaexec[1][0].ToString().Contains("b")) {
            argumentosexec = b;
        }
        else if (divicionparaexec[1][0].ToString().Contains("c")) {
            argumentosexec = c;
        }
        else if (divicionparaexec[1][0].ToString().Contains("d")) {
            argumentosexec = d;
        }
        else if (divicionparaexec[1][0].ToString().Contains("e")) {
            argumentosexec = e;
        }
        else if (divicionparaexec[1][0].ToString().Contains("f")) {
            argumentosexec = f;
        }
        else if (divicionparaexec[1][0].ToString().Contains("g")) {
            argumentosexec = g;
        }
        else if (divicionparaexec[1][0].ToString().Contains("h")) {
            argumentosexec = h;
        }
        else if (divicionparaexec[1][0].ToString().Contains("i")) {
            argumentosexec = i;
        }
        else if (divicionparaexec[1][0].ToString().Contains("j")) {
            argumentosexec = j;
        }
        else {
            argumentosexec = divicionparaexec[1];
        };

        proseso.StartInfo.FileName = archivoexec;
        proseso.StartInfo.Arguments = argumentosexec;
        proseso.StartInfo.RedirectStandardOutput = true;
        proseso.StartInfo.RedirectStandardError = true;
                                        proseso.StartInfo.UseShellExecute = false;
                                        //proseso.ErrorDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };
                                        //proseso.OutputDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };

                                        if (divicionparaexec[2][0].ToString().Contains("a")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("b")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("c")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("d")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("e")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("f")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("g")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("h")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("i")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("j")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
        }
        else {
            throw new Exception();
        };


        proseso.Start();
        /////////
    }//////////
    else {
        throw new Exception();
    };
};

                            };
                        }
                        else if (funo != Double.NaN && Double.NaN != fdos)
                        {
                            if (funo == fdos)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "�").Split('�');
for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++) {
    if (consola.IsMatch(nuevocodigo[controladordenuevo])) {
        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
        //Console.WriteLine(variablus.Length);
        if (variablus[0].ToString().Contains("a")) {
            Console.WriteLine(a);
        }
        else if (variablus[0].ToString().Contains("b")) {
            Console.WriteLine(b);
        }
        else if (variablus[0].ToString().Contains("c")) {
            Console.WriteLine(c);
        }
        else if (variablus[0].ToString().Contains("d")) {
            Console.WriteLine(d);
        }
        else if (variablus[0].ToString().Contains("e")) {
            Console.WriteLine(e);
        }
        else if (variablus[0].ToString().Contains("f")) {
            Console.WriteLine(f);
        }
        else if (variablus[0].ToString().Contains("g")) {
            Console.WriteLine(g);
        }
        else if (variablus[0].ToString().Contains("h")) {
            Console.WriteLine(h);
        }
        else if (variablus[0].ToString().Contains("i")) {
            Console.WriteLine(i);
        }
        else if (variablus[0].ToString().Contains("j")) {
            Console.WriteLine(j);
        }
        else if (variablus[0].ToString().Contains("k")) {
            Console.WriteLine(k);
        }
        else if (variablus[0].ToString().Contains("l")) {
            Console.WriteLine(l);
        }
        else if (variablus[0].ToString().Contains("m")) {
            Console.WriteLine(m);
        }
        else if (variablus[0].ToString().Contains("n")) {
            Console.WriteLine(n);
        }
        else if (variablus[0].ToString().Contains("ñ")) {
            Console.WriteLine(ñ);
        }
        else if (variablus[0].ToString().Contains("o")) {
            Console.WriteLine(o);
        }
        else if (variablus[0].ToString().Contains("p")) {
            Console.WriteLine(p);
        }
        else if (variablus[0].ToString().Contains("q")) {
            Console.WriteLine(q);
        }
        else if (variablus[0].ToString().Contains("r")) {
            Console.WriteLine(r);
        }
        else if (variablus[0].ToString().Contains("s")) {
            Console.WriteLine(s);
        }
        else if (variablus[0].ToString().Contains("t")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            //Console.WriteLine(variablus[1]);
            var consolear = t[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("u")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = u[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("v")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = v[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("w")) {
            Console.WriteLine(w);
        }
        else if (variablus[0].ToString().Contains("x")) {
            Console.WriteLine(x);
        }
        else if (variablus[0].ToString().Contains("y")) {
            Console.WriteLine(y);
        }
        else if (variablus[0].ToString().Contains("z")) {
            Console.WriteLine(z);
        }
        else {
            throw new Exception();
        };
    }
    else if (archivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "�").Split('�');
        if (File.Exists(divicionenaccion[0].Substring(3))) {
            var txt = File.ReadAllText(divicionenaccion[0].Substring(3));
            if (divicionenaccion[1].ToString().Contains("a")) {
                a = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("b")) {
                b = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("c")) {
                c = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("d")) {
                d = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("e")) {
                e = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("f")) {
                f = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("g")) {
                g = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("h")) {
                h = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("i")) {
                i = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("j")) {
                j = txt;
            }
            else {
                throw new Exception();
            };
        }
        else {
            //Console.WriteLine(divicionenaccion[0]);
            throw new Exception();
        };
    }
    else if (http.IsMatch(nuevocodigo[controladordenuevo])) {
        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
        if (link.Length == 1) {
            if (link[0].ToString().Contains("a")) {
                link = a;
            }
            else if (link[0].ToString().Contains("b")) {
                link = b;
            }
            else if (link[0].ToString().Contains("c")) {
                link = c;
            }
            else if (link[0].ToString().Contains("d")) {
                link = d;
            }
            else if (link[0].ToString().Contains("e")) {
                link = e;
            }
            else if (link[0].ToString().Contains("f")) {
                link = f;
            }
            else if (link[0].ToString().Contains("g")) {
                link = g;
            }
            else if (link[0].ToString().Contains("h")) {
                link = h;
            }
            else if (link[0].ToString().Contains("i")) {
                link = i;
            }
            else if (link[0].ToString().Contains("j")) {
                link = j;
            };
        };
        var conexion = new HttpClient();
        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
        //conexion.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
        HttpResponseMessage pagina;
        if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("get")) {
            pagina = await conexion.GetAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("delete")) {
            pagina = await conexion.DeleteAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("post")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Post;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("put")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Put;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else {
            throw new Exception();
            //pagina = await conexion.PutAsync(new Uri(link), new StringContent(nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1]));
        };
        var html = await pagina.Content.ReadAsStringAsync();
        var status1 = pagina.StatusCode.ToString();
        Double status;
        switch (status1) {
            case "Accepted":
                status = 202;
                break;
            case "Ambiguous":
                status = 300;
                break;
            case "BadGateway":
                status = 502;
                break;
            case "BadRequest":
                status = 400;
                break;
            case "Conflict":
                status = 409;
                break;
            case "Continue":
                status = 100;
                break;
            case "Created":
                status = 201;
                break;
            case "ExpectationFailed":
                status = 417;
                break;
            case "Forbidden":
                status = 403;
                break;
            case "Found":
                status = 302;
                break;
            case "GatewayTimeout":
                status = 504;
                break;
            case "Gone":
                status = 410;
                break;
            case "HttpVersionNotSupported":
                status = 505;
                break;
            case "InternalServerError":
                status = 500;
                break;
            case "LengthRequired":
                status = 411;
                break;
            case "MethodNotAllowed":
                status = 405;
                break;
            case "Moved":
                status = 301;
                break;
            case "MovedPermanently":
                status = 301;
                break;
            case "MultipleChoices":
                status = 300;
                break;
            case "NoContent":
                status = 204;
                break;
            case "NonAuthoritativeInformation":
                status = 203;
                break;
            case "NotAcceptable":
                status = 406;
                break;
            case "NotFound":
                status = 404;
                break;
            case "NotImplemented":
                status = 501;
                break;
            case "NotModified":
                status = 304;
                break;
            case "OK":
                status = 200;
                break;
            case "PartialContent":
                status = 206;
                break;
            case "PaymentRequired":
                status = 402;
                break;
            case "PreconditionFailed":
                status = 412;
                break;
            case "ProxyAuthenticationRequired":
                status = 407;
                break;
            case "Redirect":
                status = 302;
                break;
            case "RedirectKeepVerb":
                status = 307;
                break;
            case "RedirectMethod":
                status = 303;
                break;
            case "RequestedRangeNotSatisfiable":
                status = 416;
                break;
            case "RequestEntityTooLarge":
                status = 413;
                break;
            case "RequestTimeout":
                status = 408;
                break;
            case "RequestUriTooLong":
                status = 414;
                break;
            case "ResetContent":
                status = 205;
                break;
            case "SeeOther":
                status = 303;
                break;
            case "ServiceUnavailable":
                status = 503;
                break;
            case "SwitchingProtocols":
                status = 101;
                break;
            case "TemporaryRedirect":
                status = 307;
                break;
            case "Unauthorized":
                status = 401;
                break;
            case "UnsupportedMediaType":
                status = 415;
                break;
            case "Unused":
                status = 306;
                break;
            case "UpgradeRequired":
                status = 426;
                break;
            case "UseProxy":
                status = 305;
                break;
            default:
                throw new Exception();
                break;
        };
        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
        switch (varparaelstatus) {
            case "k":
                k = status;
                break;
            case "l":
                l = status;
                break;
            case "m":
                m = status;
                break;
            case "n":
                n = status;
                break;
            case "ñ":
                ñ = status;
                break;
            case "o":
                o = status;
                break;
            case "p":
                p = status;
                break;
            case "q":
                q = status;
                break;
            case "r":
                r = status;
                break;
            case "s":
                s = status;
                break;
            default:
                throw new Exception();
                break;
        };
        switch (varparalapagina) {
            case "a":
                a = html;
                break;
            case "b":
                a = html;
                break;
            case "c":
                a = html;
                break;
            case "d":
                a = html;
                break;
            case "e":
                a = html;
                break;
            case "f":
                a = html;
                break;
            case "g":
                a = html;
                break;
            case "h":
                a = html;
                break;
            case "i":
                a = html;
                break;
            case "j":
                a = html;
                break;
            default:
                throw new Exception();
                break;
        };

    }
    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo])) {



        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "�").Split('�');
        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

        ///////////////////////////////////////////
        //Console.WriteLine(arrayasignacionif[1].Length);
        var estoesarray = new Regex(".-_-.");
        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
        {
            throw new Exception();
        }*/
        if (arrayasignacionif[1][0].ToString().Contains("a")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    a = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                a = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("b")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    b = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                b = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("c")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    c = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                c = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("d")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    d = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                d = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("e")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    e = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                e = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("f")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    f = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                f = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("g")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    g = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                g = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("h")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    h = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                h = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("i")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    i = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                i = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("j")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    j = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                j = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
        {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    k = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                k = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("l")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    l = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                l = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("m")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    m = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                m = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("n")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    n = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                n = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("ñ")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    ñ = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                ñ = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("o")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    o = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                o = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("p")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    p = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                p = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("q")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    q = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                q = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("r")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    r = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                r = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("s")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    s = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                s = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("t")) {
            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion.Length; zzz++) {
                if (jajadivicion[zzz].Contains("NaN")) {
                    throw new Exception();
                }
                t[zzz] = Double.Parse(jajadivicion[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("u")) {
            u = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
        }
        else if (arrayasignacionif[1][0].ToString().Contains("v")) {
            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++) {
                v[zzz] = bool.Parse(jajadivicion2[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("w")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    w = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                w = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("x")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    x = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                x = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("y")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    y = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                y = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("z")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    z = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                z = bool.Parse(arrayasignacionif[0]);
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (salir.IsMatch(nuevocodigo[controladordenuevo])) {
        Environment.Exit(69);
    }
    else if (sleep.IsMatch(nuevocodigo[controladordenuevo])) {
        var varibleabuscar = nuevocodigo[controladordenuevo].Replace("çlbv", "");

        if (varibleabuscar[0].ToString().Contains("k")) {
            Thread.Sleep(int.Parse(k.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("l")) {
            Thread.Sleep(int.Parse(l.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("m")) {
            Thread.Sleep(int.Parse(m.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("n")) {
            Thread.Sleep(int.Parse(n.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("ñ")) {
            Thread.Sleep(int.Parse(ñ.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("o")) {
            Thread.Sleep(int.Parse(o.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("p")) {
            Thread.Sleep(int.Parse(p.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("q")) {
            Thread.Sleep(int.Parse(q.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("r")) {
            Thread.Sleep(int.Parse(r.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("s")) {
            Thread.Sleep(int.Parse(s.ToString()));
        }
        else {
            throw new Exception();
        };
    }
    else if (invertirbool.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableainvertir = nuevocodigo[controladordenuevo].Replace("!7;", "");
        if (variableainvertir[0].ToString().Contains("w")) {
            w = !w;
        }
        else if (variableainvertir[0].ToString().Contains("x")) {
            x = !x;
        }
        else if (variableainvertir[0].ToString().Contains("y")) {
            y = !y;
        }
        else if (variableainvertir[0].ToString().Contains("z")) {
            z = !z;
        }
        else {
            throw new Exception();
        };
    }
    else if (restare.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s - numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (sumedore.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s + numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (consolaentrada.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparalacomprobacion = nuevocodigo[controladordenuevo][0];
        if (variableparalacomprobacion.ToString().Contains("a")) {
            a = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("b")) {
            b = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("c")) {
            c = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("d")) {
            d = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("e")) {
            e = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("f")) {
            f = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("g")) {
            g = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("h")) {
            h = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("i")) {
            i = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("j")) {
            j = Console.ReadLine();
        }
        else {
            throw new Exception();
        };
    }
    else if (remplazar.IsMatch(nuevocodigo[controladordenuevo])) {
        var argumentos = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        string texto;
        string remplazo;
        var exp = new Regex(argumentos[1]);
        if (argumentos[0][0].ToString().Contains("a")) {
            texto = a;
        }
        else if (argumentos[0][0].ToString().Contains("b")) {
            texto = b;
        }
        else if (argumentos[0][0].ToString().Contains("c")) {
            texto = c;
        }
        else if (argumentos[0][0].ToString().Contains("d")) {
            texto = d;
        }
        else if (argumentos[0][0].ToString().Contains("e")) {
            texto = e;
        }
        else if (argumentos[0][0].ToString().Contains("f")) {
            texto = f;
        }
        else if (argumentos[0][0].ToString().Contains("g")) {
            texto = g;
        }
        else if (argumentos[0][0].ToString().Contains("h")) {
            texto = h;
        }
        else if (argumentos[0][0].ToString().Contains("i")) {
            texto = i;
        }
        else if (argumentos[0][0].ToString().Contains("j")) {
            texto = j;
        }
        else {
            throw new Exception();
        };


        if (argumentos[2][0].ToString().Contains("a")) {
            remplazo = a;
        }
        else if (argumentos[2][0].ToString().Contains("b")) {
            remplazo = b;
        }
        else if (argumentos[2][0].ToString().Contains("c")) {
            remplazo = c;
        }
        else if (argumentos[2][0].ToString().Contains("d")) {
            remplazo = d;
        }
        else if (argumentos[2][0].ToString().Contains("e")) {
            remplazo = e;
        }
        else if (argumentos[2][0].ToString().Contains("f")) {
            remplazo = f;
        }
        else if (argumentos[2][0].ToString().Contains("g")) {
            remplazo = g;
        }
        else if (argumentos[2][0].ToString().Contains("h")) {
            remplazo = h;
        }
        else if (argumentos[2][0].ToString().Contains("i")) {
            remplazo = i;
        }
        else if (argumentos[2][0].ToString().Contains("j")) {
            remplazo = j;
        }
        else {
            throw new Exception();
        };

        var resultado = exp.Replace(texto, remplazo);

        if (argumentos[3][0].ToString().Contains("a")) {
            a = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("b")) {
            b = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("c")) {
            c = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("d")) {
            d = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("e")) {
            e = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("f")) {
            f = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("g")) {
            g = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("h")) {
            h = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("i")) {
            i = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("j")) {
            j = resultado;
        }
        else {
            throw new Exception();
        };

    }//
    else if (match.IsMatch(nuevocodigo[controladordenuevo])) {
        var args = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        var expjaja = new Regex(args[0]);
        bool ismatch;

        if (args[1][0].ToString().Contains("a")) {
            if (expjaja.IsMatch(a)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("b")) {
            if (expjaja.IsMatch(b)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("c")) {
            if (expjaja.IsMatch(c)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("d")) {
            if (expjaja.IsMatch(d)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("e")) {
            if (expjaja.IsMatch(e)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("f")) {
            if (expjaja.IsMatch(f)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("g")) {
            if (expjaja.IsMatch(g)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("h")) {
            if (expjaja.IsMatch(h)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("i")) {
            if (expjaja.IsMatch(i)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("j")) {
            if (expjaja.IsMatch(j)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else {
            throw new Exception();
        };

        if (args[2][0].ToString().Contains("w")) {
            w = ismatch;
        }
        else if (args[2][0].ToString().Contains("x")) {
            x = ismatch;
        }
        else if (args[2][0].ToString().Contains("y")) {
            y = ismatch;
        }
        else if (args[2][0].ToString().Contains("z")) {
            z = ismatch;
        }
        else {
            throw new Exception();
        };

    }////////////////
    else if (editarchivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var arrayedit = nuevocodigo[controladordenuevo].Replace("👌👈", "�").Split('�');
        if (File.Exists(arrayedit[0])) {
            if (arrayedit[1][0].ToString().Contains("a")) {
                File.WriteAllText(arrayedit[0], a);
            }
            else if (arrayedit[1][0].ToString().Contains("b")) {
                File.WriteAllText(arrayedit[0], b);
            }
            else if (arrayedit[1][0].ToString().Contains("c")) {
                File.WriteAllText(arrayedit[0], c);
            }
            else if (arrayedit[1][0].ToString().Contains("d")) {
                File.WriteAllText(arrayedit[0], d);
            }
            else if (arrayedit[1][0].ToString().Contains("e")) {
                File.WriteAllText(arrayedit[0], e);
            }
            else if (arrayedit[1][0].ToString().Contains("f")) {
                File.WriteAllText(arrayedit[0], f);
            }
            else if (arrayedit[1][0].ToString().Contains("g")) {
                File.WriteAllText(arrayedit[0], g);
            }
            else if (arrayedit[1][0].ToString().Contains("h")) {
                File.WriteAllText(arrayedit[0], h);
            }
            else if (arrayedit[1][0].ToString().Contains("i")) {
                File.WriteAllText(arrayedit[0], i);
            }
            else if (arrayedit[1][0].ToString().Contains("j")) {
                File.WriteAllText(arrayedit[0], j);
            }
            else {
                throw new Exception();
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (concact.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaconcact = nuevocodigo[controladordenuevo].Replace("-/aa", "").Split('#');
        string concat1;
        string concat2;
        if (divicionparaconcact[0].ToString().Contains("a")) {
            concat1 = a;
        }
        else if (divicionparaconcact[0].ToString().Contains("b")) {
            concat1 = b;
        }
        else if (divicionparaconcact[0].ToString().Contains("c")) {
            concat1 = c;
        }
        else if (divicionparaconcact[0].ToString().Contains("d")) {
            concat1 = d;
        }
        else if (divicionparaconcact[0].ToString().Contains("e")) {
            concat1 = e;
        }
        else if (divicionparaconcact[0].ToString().Contains("f")) {
            concat1 = f;
        }
        else if (divicionparaconcact[0].ToString().Contains("g")) {
            concat1 = g;
        }
        else if (divicionparaconcact[0].ToString().Contains("h")) {
            concat1 = h;
        }
        else if (divicionparaconcact[0].ToString().Contains("i")) {
            concat1 = i;
        }
        else if (divicionparaconcact[0].ToString().Contains("j")) {
            concat1 = j;
        }
        else {
            throw new Exception();
        };


        if (divicionparaconcact[1].ToString().Contains("a")) {
            concat2 = a;
        }
        else if (divicionparaconcact[1].ToString().Contains("b")) {
            concat2 = b;
        }
        else if (divicionparaconcact[1].ToString().Contains("c")) {
            concat2 = c;
        }
        else if (divicionparaconcact[1].ToString().Contains("d")) {
            concat2 = d;
        }
        else if (divicionparaconcact[1].ToString().Contains("e")) {
            concat2 = e;
        }
        else if (divicionparaconcact[1].ToString().Contains("f")) {
            concat2 = f;
        }
        else if (divicionparaconcact[1].ToString().Contains("g")) {
            concat2 = g;
        }
        else if (divicionparaconcact[1].ToString().Contains("h")) {
            concat2 = h;
        }
        else if (divicionparaconcact[1].ToString().Contains("i")) {
            concat2 = i;
        }
        else if (divicionparaconcact[1].ToString().Contains("j")) {
            concat2 = j;
        }
        else {
            throw new Exception();
        };

        var posta = concat1 + concat2;

        if (divicionparaconcact[2].ToString().Contains("a")) {
            a = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("b")) {
            b = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("c")) {
            c = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("d")) {
            d = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("e")) {
            e = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("f")) {
            f = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("g")) {
            g = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("h")) {
            h = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("i")) {
            i = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("j")) {
            j = posta;
        }
        else {
            throw new Exception();
        };

        /////////////////
    }
    else if (controldetamaño.IsMatch(nuevocodigo[controladordenuevo])) {
        var controldetamañodivicion = nuevocodigo[controladordenuevo].Replace("gg", "").Split('¿');
        string textocontrol;

        if (controldetamañodivicion[0].ToString().Contains("a")) {
            textocontrol = a;
        }
        else if (controldetamañodivicion[0].ToString().Contains("b")) {
            textocontrol = b;
        }
        else if (controldetamañodivicion[0].ToString().Contains("c")) {
            textocontrol = c;
        }
        else if (controldetamañodivicion[0].ToString().Contains("d")) {
            textocontrol = d;
        }
        else if (controldetamañodivicion[0].ToString().Contains("e")) {
            textocontrol = e;
        }
        else if (controldetamañodivicion[0].ToString().Contains("f")) {
            textocontrol = f;
        }
        else if (controldetamañodivicion[0].ToString().Contains("g")) {
            textocontrol = g;
        }
        else if (controldetamañodivicion[0].ToString().Contains("h")) {
            textocontrol = h;
        }
        else if (controldetamañodivicion[0].ToString().Contains("i")) {
            textocontrol = i;
        }
        else if (controldetamañodivicion[0].ToString().Contains("j")) {
            textocontrol = j;
        }
        else {
            throw new Exception();
        };
        double primero;
        double segundo;

        if (controldetamañodivicion[1].ToString().Contains("k")) {
            primero = k;
        }
        else if (controldetamañodivicion[1].ToString().Contains("l")) {
            primero = l;
        }
        else if (controldetamañodivicion[1].ToString().Contains("m")) {
            primero = m;
        }
        else if (controldetamañodivicion[1].ToString().Contains("n")) {
            primero = n;
        }
        else if (controldetamañodivicion[1].ToString().Contains("ñ")) {
            primero = ñ;
        }
        else if (controldetamañodivicion[1].ToString().Contains("o")) {
            primero = o;
        }
        else if (controldetamañodivicion[1].ToString().Contains("p")) {
            primero = p;
        }
        else if (controldetamañodivicion[1].ToString().Contains("q")) {
            primero = q;
        }
        else if (controldetamañodivicion[1].ToString().Contains("r")) {
            primero = r;
        }
        else if (controldetamañodivicion[1].ToString().Contains("s")) {
            primero = s;
        }
        else {
            throw new Exception();
        };

        if (controldetamañodivicion[2].ToString().Contains("k")) {
            segundo = k;
        }
        else if (controldetamañodivicion[2].ToString().Contains("l")) {
            segundo = l;
        }
        else if (controldetamañodivicion[2].ToString().Contains("m")) {
            segundo = m;
        }
        else if (controldetamañodivicion[2].ToString().Contains("n")) {
            segundo = n;
        }
        else if (controldetamañodivicion[2].ToString().Contains("ñ")) {
            segundo = ñ;
        }
        else if (controldetamañodivicion[2].ToString().Contains("o")) {
            segundo = o;
        }
        else if (controldetamañodivicion[2].ToString().Contains("p")) {
            segundo = p;
        }
        else if (controldetamañodivicion[2].ToString().Contains("q")) {
            segundo = q;
        }
        else if (controldetamañodivicion[2].ToString().Contains("r")) {
            segundo = r;
        }
        else if (controldetamañodivicion[2].ToString().Contains("s")) {
            segundo = s;
        }
        else {
            throw new Exception();
        };

        var controlado = textocontrol.Substring(int.Parse(primero.ToString()), int.Parse(segundo.ToString()));

        if (controldetamañodivicion[3][0].ToString().Contains("a")) {
            a = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("b")) {
            b = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("c")) {
            c = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("d")) {
            d = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("e")) {
            e = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("f")) {
            f = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("g")) {
            g = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("h")) {
            h = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("i")) {
            i = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("j")) {
            j = controlado;
        }
        else {
            throw new Exception();
        };

        /////////
    }
    else if (intparse.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparaint = nuevocodigo[controladordenuevo].Replace("☺", "").Replace("♥☻", "�").Split('�');
        string aint;


        if (variableparaint[0][0].ToString().Contains("a")) {
            aint = a;
        }
        else if (variableparaint[0][0].ToString().Contains("b")) {
            aint = b;
        }
        else if (variableparaint[0][0].ToString().Contains("c")) {
            aint = c;
        }
        else if (variableparaint[0][0].ToString().Contains("d")) {
            aint = d;
        }
        else if (variableparaint[0][0].ToString().Contains("e")) {
            aint = e;
        }
        else if (variableparaint[0][0].ToString().Contains("f")) {
            aint = f;
        }
        else if (variableparaint[0][0].ToString().Contains("g")) {
            aint = g;
        }
        else if (variableparaint[0][0].ToString().Contains("h")) {
            aint = h;
        }
        else if (variableparaint[0][0].ToString().Contains("i")) {
            aint = i;
        }
        else if (variableparaint[0][0].ToString().Contains("j")) {
            aint = j;
        }
        else {
            throw new Exception();
        };

        if (variableparaint[1][0].ToString().Contains("k")) {
            k = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("l")) {
            l = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("m")) {
            m = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("n")) {
            n = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("ñ")) {
            ñ = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("o")) {
            o = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("p")) {
            p = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("q")) {
            q = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("r")) {
            r = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("s")) {
            s = Double.Parse(aint);
        }
        else {
            throw new Exception();
        };
        ///////////////
    }
    else if (reset.IsMatch(nuevocodigo[controladordenuevo])) {
        var resetdivicion = nuevocodigo[controladordenuevo].Replace("ñpqq", "");

        if (resetdivicion[0].ToString().Contains("k")) {
            xxx = int.Parse(k.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("l")) {
            xxx = int.Parse(l.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("m")) {
            xxx = int.Parse(m.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("n")) {
            xxx = int.Parse(n.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("ñ")) {
            xxx = int.Parse(ñ.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("o")) {
            xxx = int.Parse(o.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("p")) {
            xxx = int.Parse(p.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("q")) {
            xxx = int.Parse(q.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("r")) {
            xxx = int.Parse(r.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("s")) {
            xxx = int.Parse(s.ToString());
        }
        else {
            throw new Exception();
        };
        //////
    }
    else if (exec.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaexec = nuevocodigo[controladordenuevo].Replace("yyyy", "").Split('@');
        string archivoexec;
        string argumentosexec;
        var proseso = new Process();
        if (divicionparaexec[0][0].ToString().Contains("a")) {
            archivoexec = a;
        }
        else if (divicionparaexec[0][0].ToString().Contains("b")) {
            archivoexec = b;
        }
        else if (divicionparaexec[0][0].ToString().Contains("c")) {
            archivoexec = c;
        }
        else if (divicionparaexec[0][0].ToString().Contains("d")) {
            archivoexec = d;
        }
        else if (divicionparaexec[0][0].ToString().Contains("e")) {
            archivoexec = e;
        }
        else if (divicionparaexec[0][0].ToString().Contains("f")) {
            archivoexec = f;
        }
        else if (divicionparaexec[0][0].ToString().Contains("g")) {
            archivoexec = g;
        }
        else if (divicionparaexec[0][0].ToString().Contains("h")) {
            archivoexec = h;
        }
        else if (divicionparaexec[0][0].ToString().Contains("i")) {
            archivoexec = i;
        }
        else if (divicionparaexec[0][0].ToString().Contains("j")) {
            archivoexec = j;
        }
        else {
            archivoexec = divicionparaexec[0];
        };

        if (divicionparaexec[1][0].ToString().Contains("a")) {
            argumentosexec = a;
        }
        else if (divicionparaexec[1][0].ToString().Contains("b")) {
            argumentosexec = b;
        }
        else if (divicionparaexec[1][0].ToString().Contains("c")) {
            argumentosexec = c;
        }
        else if (divicionparaexec[1][0].ToString().Contains("d")) {
            argumentosexec = d;
        }
        else if (divicionparaexec[1][0].ToString().Contains("e")) {
            argumentosexec = e;
        }
        else if (divicionparaexec[1][0].ToString().Contains("f")) {
            argumentosexec = f;
        }
        else if (divicionparaexec[1][0].ToString().Contains("g")) {
            argumentosexec = g;
        }
        else if (divicionparaexec[1][0].ToString().Contains("h")) {
            argumentosexec = h;
        }
        else if (divicionparaexec[1][0].ToString().Contains("i")) {
            argumentosexec = i;
        }
        else if (divicionparaexec[1][0].ToString().Contains("j")) {
            argumentosexec = j;
        }
        else {
            argumentosexec = divicionparaexec[1];
        };

        proseso.StartInfo.FileName = archivoexec;
        proseso.StartInfo.Arguments = argumentosexec;
        proseso.StartInfo.RedirectStandardOutput = true;
        proseso.StartInfo.RedirectStandardError = true;
                                        proseso.StartInfo.UseShellExecute = false;
                                        //proseso.ErrorDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };
                                        //proseso.OutputDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };

                                        if (divicionparaexec[2][0].ToString().Contains("a")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("b")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("c")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("d")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("e")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("f")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("g")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("h")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("i")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("j")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
        }
        else {
            throw new Exception();
        };


        proseso.Start();
        /////////
    }//////////
    else {
        throw new Exception();
    };
};

                            };
                        }
                        else
                        {
                            bool buno;

                            switch (arrayasignacion[0])
                            {
                                case "w":
                                    buno = w;
                                    break;
                                case "x":
                                    buno = x;
                                    break;
                                case "y":
                                    buno = y;
                                    break;
                                case "z":
                                    buno = z;
                                    break;
                                default:
                                    throw new Exception();
                            };
                            bool bdos;
                            if (arrayasignacion[1][0].ToString().Contains("w"))
                            {
                                bdos = w;
                            }
                            else if (arrayasignacion[1][0].ToString().Contains("x"))
                            {
                                bdos = x;
                            }
                            else if (arrayasignacion[1][0].ToString().Contains("y"))
                            {
                                bdos = y;
                            }
                            else if (arrayasignacion[1][0].ToString().Contains("z"))
                            {
                                bdos = z;
                            }
                            else
                            {
                                bdos = z;
                                throw new Exception();
                            };
                            //if(buno == true) { }else if(buno == false) { } else { };
                            if (buno == true)
                            {

                                if (bdos == true)
                                {
                                    var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "�").Split('�');
for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++) {
    if (consola.IsMatch(nuevocodigo[controladordenuevo])) {
        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
        //Console.WriteLine(variablus.Length);
        if (variablus[0].ToString().Contains("a")) {
            Console.WriteLine(a);
        }
        else if (variablus[0].ToString().Contains("b")) {
            Console.WriteLine(b);
        }
        else if (variablus[0].ToString().Contains("c")) {
            Console.WriteLine(c);
        }
        else if (variablus[0].ToString().Contains("d")) {
            Console.WriteLine(d);
        }
        else if (variablus[0].ToString().Contains("e")) {
            Console.WriteLine(e);
        }
        else if (variablus[0].ToString().Contains("f")) {
            Console.WriteLine(f);
        }
        else if (variablus[0].ToString().Contains("g")) {
            Console.WriteLine(g);
        }
        else if (variablus[0].ToString().Contains("h")) {
            Console.WriteLine(h);
        }
        else if (variablus[0].ToString().Contains("i")) {
            Console.WriteLine(i);
        }
        else if (variablus[0].ToString().Contains("j")) {
            Console.WriteLine(j);
        }
        else if (variablus[0].ToString().Contains("k")) {
            Console.WriteLine(k);
        }
        else if (variablus[0].ToString().Contains("l")) {
            Console.WriteLine(l);
        }
        else if (variablus[0].ToString().Contains("m")) {
            Console.WriteLine(m);
        }
        else if (variablus[0].ToString().Contains("n")) {
            Console.WriteLine(n);
        }
        else if (variablus[0].ToString().Contains("ñ")) {
            Console.WriteLine(ñ);
        }
        else if (variablus[0].ToString().Contains("o")) {
            Console.WriteLine(o);
        }
        else if (variablus[0].ToString().Contains("p")) {
            Console.WriteLine(p);
        }
        else if (variablus[0].ToString().Contains("q")) {
            Console.WriteLine(q);
        }
        else if (variablus[0].ToString().Contains("r")) {
            Console.WriteLine(r);
        }
        else if (variablus[0].ToString().Contains("s")) {
            Console.WriteLine(s);
        }
        else if (variablus[0].ToString().Contains("t")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            //Console.WriteLine(variablus[1]);
            var consolear = t[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("u")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = u[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("v")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = v[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("w")) {
            Console.WriteLine(w);
        }
        else if (variablus[0].ToString().Contains("x")) {
            Console.WriteLine(x);
        }
        else if (variablus[0].ToString().Contains("y")) {
            Console.WriteLine(y);
        }
        else if (variablus[0].ToString().Contains("z")) {
            Console.WriteLine(z);
        }
        else {
            throw new Exception();
        };
    }
    else if (archivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "�").Split('�');
        if (File.Exists(divicionenaccion[0].Substring(3))) {
            var txt = File.ReadAllText(divicionenaccion[0].Substring(3));
            if (divicionenaccion[1].ToString().Contains("a")) {
                a = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("b")) {
                b = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("c")) {
                c = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("d")) {
                d = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("e")) {
                e = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("f")) {
                f = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("g")) {
                g = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("h")) {
                h = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("i")) {
                i = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("j")) {
                j = txt;
            }
            else {
                throw new Exception();
            };
        }
        else {
            //Console.WriteLine(divicionenaccion[0]);
            throw new Exception();
        };
    }
    else if (http.IsMatch(nuevocodigo[controladordenuevo])) {
        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
        if (link.Length == 1) {
            if (link[0].ToString().Contains("a")) {
                link = a;
            }
            else if (link[0].ToString().Contains("b")) {
                link = b;
            }
            else if (link[0].ToString().Contains("c")) {
                link = c;
            }
            else if (link[0].ToString().Contains("d")) {
                link = d;
            }
            else if (link[0].ToString().Contains("e")) {
                link = e;
            }
            else if (link[0].ToString().Contains("f")) {
                link = f;
            }
            else if (link[0].ToString().Contains("g")) {
                link = g;
            }
            else if (link[0].ToString().Contains("h")) {
                link = h;
            }
            else if (link[0].ToString().Contains("i")) {
                link = i;
            }
            else if (link[0].ToString().Contains("j")) {
                link = j;
            };
        };
        var conexion = new HttpClient();
        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
        //conexion.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
        HttpResponseMessage pagina;
        if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("get")) {
            pagina = await conexion.GetAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("delete")) {
            pagina = await conexion.DeleteAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("post")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Post;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("put")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Put;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else {
            throw new Exception();
            //pagina = await conexion.PutAsync(new Uri(link), new StringContent(nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1]));
        };
        var html = await pagina.Content.ReadAsStringAsync();
        var status1 = pagina.StatusCode.ToString();
        Double status;
        switch (status1) {
            case "Accepted":
                status = 202;
                break;
            case "Ambiguous":
                status = 300;
                break;
            case "BadGateway":
                status = 502;
                break;
            case "BadRequest":
                status = 400;
                break;
            case "Conflict":
                status = 409;
                break;
            case "Continue":
                status = 100;
                break;
            case "Created":
                status = 201;
                break;
            case "ExpectationFailed":
                status = 417;
                break;
            case "Forbidden":
                status = 403;
                break;
            case "Found":
                status = 302;
                break;
            case "GatewayTimeout":
                status = 504;
                break;
            case "Gone":
                status = 410;
                break;
            case "HttpVersionNotSupported":
                status = 505;
                break;
            case "InternalServerError":
                status = 500;
                break;
            case "LengthRequired":
                status = 411;
                break;
            case "MethodNotAllowed":
                status = 405;
                break;
            case "Moved":
                status = 301;
                break;
            case "MovedPermanently":
                status = 301;
                break;
            case "MultipleChoices":
                status = 300;
                break;
            case "NoContent":
                status = 204;
                break;
            case "NonAuthoritativeInformation":
                status = 203;
                break;
            case "NotAcceptable":
                status = 406;
                break;
            case "NotFound":
                status = 404;
                break;
            case "NotImplemented":
                status = 501;
                break;
            case "NotModified":
                status = 304;
                break;
            case "OK":
                status = 200;
                break;
            case "PartialContent":
                status = 206;
                break;
            case "PaymentRequired":
                status = 402;
                break;
            case "PreconditionFailed":
                status = 412;
                break;
            case "ProxyAuthenticationRequired":
                status = 407;
                break;
            case "Redirect":
                status = 302;
                break;
            case "RedirectKeepVerb":
                status = 307;
                break;
            case "RedirectMethod":
                status = 303;
                break;
            case "RequestedRangeNotSatisfiable":
                status = 416;
                break;
            case "RequestEntityTooLarge":
                status = 413;
                break;
            case "RequestTimeout":
                status = 408;
                break;
            case "RequestUriTooLong":
                status = 414;
                break;
            case "ResetContent":
                status = 205;
                break;
            case "SeeOther":
                status = 303;
                break;
            case "ServiceUnavailable":
                status = 503;
                break;
            case "SwitchingProtocols":
                status = 101;
                break;
            case "TemporaryRedirect":
                status = 307;
                break;
            case "Unauthorized":
                status = 401;
                break;
            case "UnsupportedMediaType":
                status = 415;
                break;
            case "Unused":
                status = 306;
                break;
            case "UpgradeRequired":
                status = 426;
                break;
            case "UseProxy":
                status = 305;
                break;
            default:
                throw new Exception();
                break;
        };
        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
        switch (varparaelstatus) {
            case "k":
                k = status;
                break;
            case "l":
                l = status;
                break;
            case "m":
                m = status;
                break;
            case "n":
                n = status;
                break;
            case "ñ":
                ñ = status;
                break;
            case "o":
                o = status;
                break;
            case "p":
                p = status;
                break;
            case "q":
                q = status;
                break;
            case "r":
                r = status;
                break;
            case "s":
                s = status;
                break;
            default:
                throw new Exception();
                break;
        };
        switch (varparalapagina) {
            case "a":
                a = html;
                break;
            case "b":
                a = html;
                break;
            case "c":
                a = html;
                break;
            case "d":
                a = html;
                break;
            case "e":
                a = html;
                break;
            case "f":
                a = html;
                break;
            case "g":
                a = html;
                break;
            case "h":
                a = html;
                break;
            case "i":
                a = html;
                break;
            case "j":
                a = html;
                break;
            default:
                throw new Exception();
                break;
        };

    }
    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo])) {



        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "�").Split('�');
        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

        ///////////////////////////////////////////
        //Console.WriteLine(arrayasignacionif[1].Length);
        var estoesarray = new Regex(".-_-.");
        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
        {
            throw new Exception();
        }*/
        if (arrayasignacionif[1][0].ToString().Contains("a")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    a = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                a = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("b")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    b = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                b = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("c")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    c = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                c = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("d")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    d = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                d = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("e")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    e = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                e = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("f")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    f = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                f = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("g")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    g = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                g = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("h")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    h = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                h = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("i")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    i = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                i = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("j")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    j = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                j = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
        {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    k = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                k = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("l")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    l = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                l = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("m")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    m = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                m = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("n")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    n = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                n = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("ñ")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    ñ = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                ñ = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("o")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    o = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                o = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("p")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    p = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                p = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("q")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    q = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                q = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("r")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    r = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                r = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("s")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    s = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                s = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("t")) {
            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion.Length; zzz++) {
                if (jajadivicion[zzz].Contains("NaN")) {
                    throw new Exception();
                }
                t[zzz] = Double.Parse(jajadivicion[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("u")) {
            u = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
        }
        else if (arrayasignacionif[1][0].ToString().Contains("v")) {
            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++) {
                v[zzz] = bool.Parse(jajadivicion2[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("w")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    w = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                w = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("x")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    x = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                x = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("y")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    y = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                y = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("z")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    z = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                z = bool.Parse(arrayasignacionif[0]);
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (salir.IsMatch(nuevocodigo[controladordenuevo])) {
        Environment.Exit(69);
    }
    else if (sleep.IsMatch(nuevocodigo[controladordenuevo])) {
        var varibleabuscar = nuevocodigo[controladordenuevo].Replace("çlbv", "");

        if (varibleabuscar[0].ToString().Contains("k")) {
            Thread.Sleep(int.Parse(k.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("l")) {
            Thread.Sleep(int.Parse(l.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("m")) {
            Thread.Sleep(int.Parse(m.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("n")) {
            Thread.Sleep(int.Parse(n.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("ñ")) {
            Thread.Sleep(int.Parse(ñ.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("o")) {
            Thread.Sleep(int.Parse(o.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("p")) {
            Thread.Sleep(int.Parse(p.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("q")) {
            Thread.Sleep(int.Parse(q.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("r")) {
            Thread.Sleep(int.Parse(r.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("s")) {
            Thread.Sleep(int.Parse(s.ToString()));
        }
        else {
            throw new Exception();
        };
    }
    else if (invertirbool.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableainvertir = nuevocodigo[controladordenuevo].Replace("!7;", "");
        if (variableainvertir[0].ToString().Contains("w")) {
            w = !w;
        }
        else if (variableainvertir[0].ToString().Contains("x")) {
            x = !x;
        }
        else if (variableainvertir[0].ToString().Contains("y")) {
            y = !y;
        }
        else if (variableainvertir[0].ToString().Contains("z")) {
            z = !z;
        }
        else {
            throw new Exception();
        };
    }
    else if (restare.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s - numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (sumedore.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s + numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (consolaentrada.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparalacomprobacion = nuevocodigo[controladordenuevo][0];
        if (variableparalacomprobacion.ToString().Contains("a")) {
            a = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("b")) {
            b = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("c")) {
            c = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("d")) {
            d = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("e")) {
            e = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("f")) {
            f = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("g")) {
            g = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("h")) {
            h = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("i")) {
            i = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("j")) {
            j = Console.ReadLine();
        }
        else {
            throw new Exception();
        };
    }
    else if (remplazar.IsMatch(nuevocodigo[controladordenuevo])) {
        var argumentos = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        string texto;
        string remplazo;
        var exp = new Regex(argumentos[1]);
        if (argumentos[0][0].ToString().Contains("a")) {
            texto = a;
        }
        else if (argumentos[0][0].ToString().Contains("b")) {
            texto = b;
        }
        else if (argumentos[0][0].ToString().Contains("c")) {
            texto = c;
        }
        else if (argumentos[0][0].ToString().Contains("d")) {
            texto = d;
        }
        else if (argumentos[0][0].ToString().Contains("e")) {
            texto = e;
        }
        else if (argumentos[0][0].ToString().Contains("f")) {
            texto = f;
        }
        else if (argumentos[0][0].ToString().Contains("g")) {
            texto = g;
        }
        else if (argumentos[0][0].ToString().Contains("h")) {
            texto = h;
        }
        else if (argumentos[0][0].ToString().Contains("i")) {
            texto = i;
        }
        else if (argumentos[0][0].ToString().Contains("j")) {
            texto = j;
        }
        else {
            throw new Exception();
        };


        if (argumentos[2][0].ToString().Contains("a")) {
            remplazo = a;
        }
        else if (argumentos[2][0].ToString().Contains("b")) {
            remplazo = b;
        }
        else if (argumentos[2][0].ToString().Contains("c")) {
            remplazo = c;
        }
        else if (argumentos[2][0].ToString().Contains("d")) {
            remplazo = d;
        }
        else if (argumentos[2][0].ToString().Contains("e")) {
            remplazo = e;
        }
        else if (argumentos[2][0].ToString().Contains("f")) {
            remplazo = f;
        }
        else if (argumentos[2][0].ToString().Contains("g")) {
            remplazo = g;
        }
        else if (argumentos[2][0].ToString().Contains("h")) {
            remplazo = h;
        }
        else if (argumentos[2][0].ToString().Contains("i")) {
            remplazo = i;
        }
        else if (argumentos[2][0].ToString().Contains("j")) {
            remplazo = j;
        }
        else {
            throw new Exception();
        };

        var resultado = exp.Replace(texto, remplazo);

        if (argumentos[3][0].ToString().Contains("a")) {
            a = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("b")) {
            b = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("c")) {
            c = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("d")) {
            d = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("e")) {
            e = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("f")) {
            f = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("g")) {
            g = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("h")) {
            h = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("i")) {
            i = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("j")) {
            j = resultado;
        }
        else {
            throw new Exception();
        };

    }//
    else if (match.IsMatch(nuevocodigo[controladordenuevo])) {
        var args = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        var expjaja = new Regex(args[0]);
        bool ismatch;

        if (args[1][0].ToString().Contains("a")) {
            if (expjaja.IsMatch(a)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("b")) {
            if (expjaja.IsMatch(b)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("c")) {
            if (expjaja.IsMatch(c)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("d")) {
            if (expjaja.IsMatch(d)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("e")) {
            if (expjaja.IsMatch(e)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("f")) {
            if (expjaja.IsMatch(f)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("g")) {
            if (expjaja.IsMatch(g)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("h")) {
            if (expjaja.IsMatch(h)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("i")) {
            if (expjaja.IsMatch(i)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("j")) {
            if (expjaja.IsMatch(j)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else {
            throw new Exception();
        };

        if (args[2][0].ToString().Contains("w")) {
            w = ismatch;
        }
        else if (args[2][0].ToString().Contains("x")) {
            x = ismatch;
        }
        else if (args[2][0].ToString().Contains("y")) {
            y = ismatch;
        }
        else if (args[2][0].ToString().Contains("z")) {
            z = ismatch;
        }
        else {
            throw new Exception();
        };

    }////////////////
    else if (editarchivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var arrayedit = nuevocodigo[controladordenuevo].Replace("👌👈", "�").Split('�');
        if (File.Exists(arrayedit[0])) {
            if (arrayedit[1][0].ToString().Contains("a")) {
                File.WriteAllText(arrayedit[0], a);
            }
            else if (arrayedit[1][0].ToString().Contains("b")) {
                File.WriteAllText(arrayedit[0], b);
            }
            else if (arrayedit[1][0].ToString().Contains("c")) {
                File.WriteAllText(arrayedit[0], c);
            }
            else if (arrayedit[1][0].ToString().Contains("d")) {
                File.WriteAllText(arrayedit[0], d);
            }
            else if (arrayedit[1][0].ToString().Contains("e")) {
                File.WriteAllText(arrayedit[0], e);
            }
            else if (arrayedit[1][0].ToString().Contains("f")) {
                File.WriteAllText(arrayedit[0], f);
            }
            else if (arrayedit[1][0].ToString().Contains("g")) {
                File.WriteAllText(arrayedit[0], g);
            }
            else if (arrayedit[1][0].ToString().Contains("h")) {
                File.WriteAllText(arrayedit[0], h);
            }
            else if (arrayedit[1][0].ToString().Contains("i")) {
                File.WriteAllText(arrayedit[0], i);
            }
            else if (arrayedit[1][0].ToString().Contains("j")) {
                File.WriteAllText(arrayedit[0], j);
            }
            else {
                throw new Exception();
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (concact.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaconcact = nuevocodigo[controladordenuevo].Replace("-/aa", "").Split('#');
        string concat1;
        string concat2;
        if (divicionparaconcact[0].ToString().Contains("a")) {
            concat1 = a;
        }
        else if (divicionparaconcact[0].ToString().Contains("b")) {
            concat1 = b;
        }
        else if (divicionparaconcact[0].ToString().Contains("c")) {
            concat1 = c;
        }
        else if (divicionparaconcact[0].ToString().Contains("d")) {
            concat1 = d;
        }
        else if (divicionparaconcact[0].ToString().Contains("e")) {
            concat1 = e;
        }
        else if (divicionparaconcact[0].ToString().Contains("f")) {
            concat1 = f;
        }
        else if (divicionparaconcact[0].ToString().Contains("g")) {
            concat1 = g;
        }
        else if (divicionparaconcact[0].ToString().Contains("h")) {
            concat1 = h;
        }
        else if (divicionparaconcact[0].ToString().Contains("i")) {
            concat1 = i;
        }
        else if (divicionparaconcact[0].ToString().Contains("j")) {
            concat1 = j;
        }
        else {
            throw new Exception();
        };


        if (divicionparaconcact[1].ToString().Contains("a")) {
            concat2 = a;
        }
        else if (divicionparaconcact[1].ToString().Contains("b")) {
            concat2 = b;
        }
        else if (divicionparaconcact[1].ToString().Contains("c")) {
            concat2 = c;
        }
        else if (divicionparaconcact[1].ToString().Contains("d")) {
            concat2 = d;
        }
        else if (divicionparaconcact[1].ToString().Contains("e")) {
            concat2 = e;
        }
        else if (divicionparaconcact[1].ToString().Contains("f")) {
            concat2 = f;
        }
        else if (divicionparaconcact[1].ToString().Contains("g")) {
            concat2 = g;
        }
        else if (divicionparaconcact[1].ToString().Contains("h")) {
            concat2 = h;
        }
        else if (divicionparaconcact[1].ToString().Contains("i")) {
            concat2 = i;
        }
        else if (divicionparaconcact[1].ToString().Contains("j")) {
            concat2 = j;
        }
        else {
            throw new Exception();
        };

        var posta = concat1 + concat2;

        if (divicionparaconcact[2].ToString().Contains("a")) {
            a = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("b")) {
            b = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("c")) {
            c = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("d")) {
            d = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("e")) {
            e = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("f")) {
            f = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("g")) {
            g = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("h")) {
            h = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("i")) {
            i = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("j")) {
            j = posta;
        }
        else {
            throw new Exception();
        };

        /////////////////
    }
    else if (controldetamaño.IsMatch(nuevocodigo[controladordenuevo])) {
        var controldetamañodivicion = nuevocodigo[controladordenuevo].Replace("gg", "").Split('¿');
        string textocontrol;

        if (controldetamañodivicion[0].ToString().Contains("a")) {
            textocontrol = a;
        }
        else if (controldetamañodivicion[0].ToString().Contains("b")) {
            textocontrol = b;
        }
        else if (controldetamañodivicion[0].ToString().Contains("c")) {
            textocontrol = c;
        }
        else if (controldetamañodivicion[0].ToString().Contains("d")) {
            textocontrol = d;
        }
        else if (controldetamañodivicion[0].ToString().Contains("e")) {
            textocontrol = e;
        }
        else if (controldetamañodivicion[0].ToString().Contains("f")) {
            textocontrol = f;
        }
        else if (controldetamañodivicion[0].ToString().Contains("g")) {
            textocontrol = g;
        }
        else if (controldetamañodivicion[0].ToString().Contains("h")) {
            textocontrol = h;
        }
        else if (controldetamañodivicion[0].ToString().Contains("i")) {
            textocontrol = i;
        }
        else if (controldetamañodivicion[0].ToString().Contains("j")) {
            textocontrol = j;
        }
        else {
            throw new Exception();
        };
        double primero;
        double segundo;

        if (controldetamañodivicion[1].ToString().Contains("k")) {
            primero = k;
        }
        else if (controldetamañodivicion[1].ToString().Contains("l")) {
            primero = l;
        }
        else if (controldetamañodivicion[1].ToString().Contains("m")) {
            primero = m;
        }
        else if (controldetamañodivicion[1].ToString().Contains("n")) {
            primero = n;
        }
        else if (controldetamañodivicion[1].ToString().Contains("ñ")) {
            primero = ñ;
        }
        else if (controldetamañodivicion[1].ToString().Contains("o")) {
            primero = o;
        }
        else if (controldetamañodivicion[1].ToString().Contains("p")) {
            primero = p;
        }
        else if (controldetamañodivicion[1].ToString().Contains("q")) {
            primero = q;
        }
        else if (controldetamañodivicion[1].ToString().Contains("r")) {
            primero = r;
        }
        else if (controldetamañodivicion[1].ToString().Contains("s")) {
            primero = s;
        }
        else {
            throw new Exception();
        };

        if (controldetamañodivicion[2].ToString().Contains("k")) {
            segundo = k;
        }
        else if (controldetamañodivicion[2].ToString().Contains("l")) {
            segundo = l;
        }
        else if (controldetamañodivicion[2].ToString().Contains("m")) {
            segundo = m;
        }
        else if (controldetamañodivicion[2].ToString().Contains("n")) {
            segundo = n;
        }
        else if (controldetamañodivicion[2].ToString().Contains("ñ")) {
            segundo = ñ;
        }
        else if (controldetamañodivicion[2].ToString().Contains("o")) {
            segundo = o;
        }
        else if (controldetamañodivicion[2].ToString().Contains("p")) {
            segundo = p;
        }
        else if (controldetamañodivicion[2].ToString().Contains("q")) {
            segundo = q;
        }
        else if (controldetamañodivicion[2].ToString().Contains("r")) {
            segundo = r;
        }
        else if (controldetamañodivicion[2].ToString().Contains("s")) {
            segundo = s;
        }
        else {
            throw new Exception();
        };

        var controlado = textocontrol.Substring(int.Parse(primero.ToString()), int.Parse(segundo.ToString()));

        if (controldetamañodivicion[3][0].ToString().Contains("a")) {
            a = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("b")) {
            b = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("c")) {
            c = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("d")) {
            d = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("e")) {
            e = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("f")) {
            f = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("g")) {
            g = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("h")) {
            h = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("i")) {
            i = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("j")) {
            j = controlado;
        }
        else {
            throw new Exception();
        };

        /////////
    }
    else if (intparse.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparaint = nuevocodigo[controladordenuevo].Replace("☺", "").Replace("♥☻", "�").Split('�');
        string aint;


        if (variableparaint[0][0].ToString().Contains("a")) {
            aint = a;
        }
        else if (variableparaint[0][0].ToString().Contains("b")) {
            aint = b;
        }
        else if (variableparaint[0][0].ToString().Contains("c")) {
            aint = c;
        }
        else if (variableparaint[0][0].ToString().Contains("d")) {
            aint = d;
        }
        else if (variableparaint[0][0].ToString().Contains("e")) {
            aint = e;
        }
        else if (variableparaint[0][0].ToString().Contains("f")) {
            aint = f;
        }
        else if (variableparaint[0][0].ToString().Contains("g")) {
            aint = g;
        }
        else if (variableparaint[0][0].ToString().Contains("h")) {
            aint = h;
        }
        else if (variableparaint[0][0].ToString().Contains("i")) {
            aint = i;
        }
        else if (variableparaint[0][0].ToString().Contains("j")) {
            aint = j;
        }
        else {
            throw new Exception();
        };

        if (variableparaint[1][0].ToString().Contains("k")) {
            k = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("l")) {
            l = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("m")) {
            m = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("n")) {
            n = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("ñ")) {
            ñ = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("o")) {
            o = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("p")) {
            p = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("q")) {
            q = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("r")) {
            r = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("s")) {
            s = Double.Parse(aint);
        }
        else {
            throw new Exception();
        };
        ///////////////
    }
    else if (reset.IsMatch(nuevocodigo[controladordenuevo])) {
        var resetdivicion = nuevocodigo[controladordenuevo].Replace("ñpqq", "");

        if (resetdivicion[0].ToString().Contains("k")) {
            xxx = int.Parse(k.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("l")) {
            xxx = int.Parse(l.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("m")) {
            xxx = int.Parse(m.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("n")) {
            xxx = int.Parse(n.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("ñ")) {
            xxx = int.Parse(ñ.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("o")) {
            xxx = int.Parse(o.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("p")) {
            xxx = int.Parse(p.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("q")) {
            xxx = int.Parse(q.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("r")) {
            xxx = int.Parse(r.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("s")) {
            xxx = int.Parse(s.ToString());
        }
        else {
            throw new Exception();
        };
        //////
    }
    else if (exec.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaexec = nuevocodigo[controladordenuevo].Replace("yyyy", "").Split('@');
        string archivoexec;
        string argumentosexec;
        var proseso = new Process();
        if (divicionparaexec[0][0].ToString().Contains("a")) {
            archivoexec = a;
        }
        else if (divicionparaexec[0][0].ToString().Contains("b")) {
            archivoexec = b;
        }
        else if (divicionparaexec[0][0].ToString().Contains("c")) {
            archivoexec = c;
        }
        else if (divicionparaexec[0][0].ToString().Contains("d")) {
            archivoexec = d;
        }
        else if (divicionparaexec[0][0].ToString().Contains("e")) {
            archivoexec = e;
        }
        else if (divicionparaexec[0][0].ToString().Contains("f")) {
            archivoexec = f;
        }
        else if (divicionparaexec[0][0].ToString().Contains("g")) {
            archivoexec = g;
        }
        else if (divicionparaexec[0][0].ToString().Contains("h")) {
            archivoexec = h;
        }
        else if (divicionparaexec[0][0].ToString().Contains("i")) {
            archivoexec = i;
        }
        else if (divicionparaexec[0][0].ToString().Contains("j")) {
            archivoexec = j;
        }
        else {
            archivoexec = divicionparaexec[0];
        };

        if (divicionparaexec[1][0].ToString().Contains("a")) {
            argumentosexec = a;
        }
        else if (divicionparaexec[1][0].ToString().Contains("b")) {
            argumentosexec = b;
        }
        else if (divicionparaexec[1][0].ToString().Contains("c")) {
            argumentosexec = c;
        }
        else if (divicionparaexec[1][0].ToString().Contains("d")) {
            argumentosexec = d;
        }
        else if (divicionparaexec[1][0].ToString().Contains("e")) {
            argumentosexec = e;
        }
        else if (divicionparaexec[1][0].ToString().Contains("f")) {
            argumentosexec = f;
        }
        else if (divicionparaexec[1][0].ToString().Contains("g")) {
            argumentosexec = g;
        }
        else if (divicionparaexec[1][0].ToString().Contains("h")) {
            argumentosexec = h;
        }
        else if (divicionparaexec[1][0].ToString().Contains("i")) {
            argumentosexec = i;
        }
        else if (divicionparaexec[1][0].ToString().Contains("j")) {
            argumentosexec = j;
        }
        else {
            argumentosexec = divicionparaexec[1];
        };

        proseso.StartInfo.FileName = archivoexec;
        proseso.StartInfo.Arguments = argumentosexec;
        proseso.StartInfo.RedirectStandardOutput = true;
        proseso.StartInfo.RedirectStandardError = true;
                                            proseso.StartInfo.UseShellExecute = false;
                                            //proseso.ErrorDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };
                                            //proseso.OutputDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };

                                            if (divicionparaexec[2][0].ToString().Contains("a")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("b")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("c")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("d")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("e")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("f")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("g")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("h")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("i")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("j")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
        }
        else {
            throw new Exception();
        };


        proseso.Start();
        /////////
    }//////////
    else {
        throw new Exception();
    };
};

                                };
                            }
                            else if (buno == false)
                            {
                                if (bdos == false)
                                {
                                    var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "�").Split('�');
for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++) {
    if (consola.IsMatch(nuevocodigo[controladordenuevo])) {
        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
        //Console.WriteLine(variablus.Length);
        if (variablus[0].ToString().Contains("a")) {
            Console.WriteLine(a);
        }
        else if (variablus[0].ToString().Contains("b")) {
            Console.WriteLine(b);
        }
        else if (variablus[0].ToString().Contains("c")) {
            Console.WriteLine(c);
        }
        else if (variablus[0].ToString().Contains("d")) {
            Console.WriteLine(d);
        }
        else if (variablus[0].ToString().Contains("e")) {
            Console.WriteLine(e);
        }
        else if (variablus[0].ToString().Contains("f")) {
            Console.WriteLine(f);
        }
        else if (variablus[0].ToString().Contains("g")) {
            Console.WriteLine(g);
        }
        else if (variablus[0].ToString().Contains("h")) {
            Console.WriteLine(h);
        }
        else if (variablus[0].ToString().Contains("i")) {
            Console.WriteLine(i);
        }
        else if (variablus[0].ToString().Contains("j")) {
            Console.WriteLine(j);
        }
        else if (variablus[0].ToString().Contains("k")) {
            Console.WriteLine(k);
        }
        else if (variablus[0].ToString().Contains("l")) {
            Console.WriteLine(l);
        }
        else if (variablus[0].ToString().Contains("m")) {
            Console.WriteLine(m);
        }
        else if (variablus[0].ToString().Contains("n")) {
            Console.WriteLine(n);
        }
        else if (variablus[0].ToString().Contains("ñ")) {
            Console.WriteLine(ñ);
        }
        else if (variablus[0].ToString().Contains("o")) {
            Console.WriteLine(o);
        }
        else if (variablus[0].ToString().Contains("p")) {
            Console.WriteLine(p);
        }
        else if (variablus[0].ToString().Contains("q")) {
            Console.WriteLine(q);
        }
        else if (variablus[0].ToString().Contains("r")) {
            Console.WriteLine(r);
        }
        else if (variablus[0].ToString().Contains("s")) {
            Console.WriteLine(s);
        }
        else if (variablus[0].ToString().Contains("t")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            //Console.WriteLine(variablus[1]);
            var consolear = t[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("u")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = u[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("v")) {
            var numero = variablus.Replace("-_-", "�").Split('�');
            var consolear = v[int.Parse(numero[1].ToString())];
            Console.WriteLine(consolear);
        }
        else if (variablus[0].ToString().Contains("w")) {
            Console.WriteLine(w);
        }
        else if (variablus[0].ToString().Contains("x")) {
            Console.WriteLine(x);
        }
        else if (variablus[0].ToString().Contains("y")) {
            Console.WriteLine(y);
        }
        else if (variablus[0].ToString().Contains("z")) {
            Console.WriteLine(z);
        }
        else {
            throw new Exception();
        };
    }
    else if (archivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "�").Split('�');
        if (File.Exists(divicionenaccion[0].Substring(3))) {
            var txt = File.ReadAllText(divicionenaccion[0].Substring(3));
            if (divicionenaccion[1].ToString().Contains("a")) {
                a = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("b")) {
                b = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("c")) {
                c = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("d")) {
                d = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("e")) {
                e = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("f")) {
                f = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("g")) {
                g = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("h")) {
                h = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("i")) {
                i = txt;
            }
            else if (divicionenaccion[1].ToString().Contains("j")) {
                j = txt;
            }
            else {
                throw new Exception();
            };
        }
        else {
            //Console.WriteLine(divicionenaccion[0]);
            throw new Exception();
        };
    }
    else if (http.IsMatch(nuevocodigo[controladordenuevo])) {
        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
        if (link.Length == 1) {
            if (link[0].ToString().Contains("a")) {
                link = a;
            }
            else if (link[0].ToString().Contains("b")) {
                link = b;
            }
            else if (link[0].ToString().Contains("c")) {
                link = c;
            }
            else if (link[0].ToString().Contains("d")) {
                link = d;
            }
            else if (link[0].ToString().Contains("e")) {
                link = e;
            }
            else if (link[0].ToString().Contains("f")) {
                link = f;
            }
            else if (link[0].ToString().Contains("g")) {
                link = g;
            }
            else if (link[0].ToString().Contains("h")) {
                link = h;
            }
            else if (link[0].ToString().Contains("i")) {
                link = i;
            }
            else if (link[0].ToString().Contains("j")) {
                link = j;
            };
        };
        var conexion = new HttpClient();
        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
        //conexion.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
        HttpResponseMessage pagina;
        if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("get")) {
            pagina = await conexion.GetAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].ToLower().Contains("delete")) {
            pagina = await conexion.DeleteAsync(link);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("post")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Post;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else if (nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[0].ToLower().Contains("put")) {
            var peticion = new HttpRequestMessage();
            peticion.Method = System.Net.Http.HttpMethod.Put;
            conexion.BaseAddress = new Uri(link);
            peticion.Headers.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2]);
            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[4].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[4].Length - 1));
            var contenidoss = nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1];
            if (contenidoss.Length == 1) {
                if (contenidoss[0].ToString().Contains("a")) {
                    contenidoss = a;
                }
                else if (contenidoss[0].ToString().Contains("b")) {
                    contenidoss = b;
                }
                else if (contenidoss[0].ToString().Contains("c")) {
                    contenidoss = c;
                }
                else if (contenidoss[0].ToString().Contains("d")) {
                    contenidoss = d;
                }
                else if (contenidoss[0].ToString().Contains("e")) {
                    contenidoss = e;
                }
                else if (contenidoss[0].ToString().Contains("f")) {
                    contenidoss = f;
                }
                else if (contenidoss[0].ToString().Contains("g")) {
                    contenidoss = g;
                }
                else if (contenidoss[0].ToString().Contains("h")) {
                    contenidoss = h;
                }
                else if (contenidoss[0].ToString().Contains("i")) {
                    contenidoss = i;
                }
                else if (contenidoss[0].ToString().Contains("j")) {
                    contenidoss = j;
                };
            };

            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[2].Length - 1));


            pagina = await conexion.SendAsync(peticion);
        }
        else {
            throw new Exception();
            //pagina = await conexion.PutAsync(new Uri(link), new StringContent(nuevocodigo[controladordenuevo].Split('¿')[3].Split('|')[1]));
        };
        var html = await pagina.Content.ReadAsStringAsync();
        var status1 = pagina.StatusCode.ToString();
        Double status;
        switch (status1) {
            case "Accepted":
                status = 202;
                break;
            case "Ambiguous":
                status = 300;
                break;
            case "BadGateway":
                status = 502;
                break;
            case "BadRequest":
                status = 400;
                break;
            case "Conflict":
                status = 409;
                break;
            case "Continue":
                status = 100;
                break;
            case "Created":
                status = 201;
                break;
            case "ExpectationFailed":
                status = 417;
                break;
            case "Forbidden":
                status = 403;
                break;
            case "Found":
                status = 302;
                break;
            case "GatewayTimeout":
                status = 504;
                break;
            case "Gone":
                status = 410;
                break;
            case "HttpVersionNotSupported":
                status = 505;
                break;
            case "InternalServerError":
                status = 500;
                break;
            case "LengthRequired":
                status = 411;
                break;
            case "MethodNotAllowed":
                status = 405;
                break;
            case "Moved":
                status = 301;
                break;
            case "MovedPermanently":
                status = 301;
                break;
            case "MultipleChoices":
                status = 300;
                break;
            case "NoContent":
                status = 204;
                break;
            case "NonAuthoritativeInformation":
                status = 203;
                break;
            case "NotAcceptable":
                status = 406;
                break;
            case "NotFound":
                status = 404;
                break;
            case "NotImplemented":
                status = 501;
                break;
            case "NotModified":
                status = 304;
                break;
            case "OK":
                status = 200;
                break;
            case "PartialContent":
                status = 206;
                break;
            case "PaymentRequired":
                status = 402;
                break;
            case "PreconditionFailed":
                status = 412;
                break;
            case "ProxyAuthenticationRequired":
                status = 407;
                break;
            case "Redirect":
                status = 302;
                break;
            case "RedirectKeepVerb":
                status = 307;
                break;
            case "RedirectMethod":
                status = 303;
                break;
            case "RequestedRangeNotSatisfiable":
                status = 416;
                break;
            case "RequestEntityTooLarge":
                status = 413;
                break;
            case "RequestTimeout":
                status = 408;
                break;
            case "RequestUriTooLong":
                status = 414;
                break;
            case "ResetContent":
                status = 205;
                break;
            case "SeeOther":
                status = 303;
                break;
            case "ServiceUnavailable":
                status = 503;
                break;
            case "SwitchingProtocols":
                status = 101;
                break;
            case "TemporaryRedirect":
                status = 307;
                break;
            case "Unauthorized":
                status = 401;
                break;
            case "UnsupportedMediaType":
                status = 415;
                break;
            case "Unused":
                status = 306;
                break;
            case "UpgradeRequired":
                status = 426;
                break;
            case "UseProxy":
                status = 305;
                break;
            default:
                throw new Exception();
                break;
        };
        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
        switch (varparaelstatus) {
            case "k":
                k = status;
                break;
            case "l":
                l = status;
                break;
            case "m":
                m = status;
                break;
            case "n":
                n = status;
                break;
            case "ñ":
                ñ = status;
                break;
            case "o":
                o = status;
                break;
            case "p":
                p = status;
                break;
            case "q":
                q = status;
                break;
            case "r":
                r = status;
                break;
            case "s":
                s = status;
                break;
            default:
                throw new Exception();
                break;
        };
        switch (varparalapagina) {
            case "a":
                a = html;
                break;
            case "b":
                a = html;
                break;
            case "c":
                a = html;
                break;
            case "d":
                a = html;
                break;
            case "e":
                a = html;
                break;
            case "f":
                a = html;
                break;
            case "g":
                a = html;
                break;
            case "h":
                a = html;
                break;
            case "i":
                a = html;
                break;
            case "j":
                a = html;
                break;
            default:
                throw new Exception();
                break;
        };

    }
    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo])) {



        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "�").Split('�');
        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

        ///////////////////////////////////////////
        //Console.WriteLine(arrayasignacionif[1].Length);
        var estoesarray = new Regex(".-_-.");
        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
        {
            throw new Exception();
        }*/
        if (arrayasignacionif[1][0].ToString().Contains("a")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    a = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                a = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("b")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    b = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                b = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("c")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    c = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                c = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("d")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    d = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                d = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("e")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    e = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                e = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("f")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    f = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                f = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("g")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    g = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                g = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("h")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    h = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                h = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("i")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    i = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                i = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("j")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("u")) {
                    j = u[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                j = arrayasignacionif[0];
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
        {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    k = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                k = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("l")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    l = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                l = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("m")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    m = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                m = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("n")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    n = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                n = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("ñ")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    ñ = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                ñ = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("o")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    o = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                o = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("p")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    p = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                p = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("q")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    q = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                q = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("r")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    r = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                r = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("s")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("t")) {
                    s = t[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                s = Double.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("t")) {
            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion.Length; zzz++) {
                if (jajadivicion[zzz].Contains("NaN")) {
                    throw new Exception();
                }
                t[zzz] = Double.Parse(jajadivicion[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("u")) {
            u = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
        }
        else if (arrayasignacionif[1][0].ToString().Contains("v")) {
            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "�").Split('�');
            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++) {
                v[zzz] = bool.Parse(jajadivicion2[zzz]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("w")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    w = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                w = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("x")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    x = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                x = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("y")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    y = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                y = bool.Parse(arrayasignacionif[0]);
            };
        }
        else if (arrayasignacionif[1][0].ToString().Contains("z")) {
            if (estoesarray.IsMatch(arrayasignacionif[0])) {
                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "�").Split('�');
                if (divicionSuprema[0][0].ToString().Contains("v")) {
                    z = v[int.Parse(divicionSuprema[1])];
                }
                else {
                    throw new Exception();
                };
            }
            else {
                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                z = bool.Parse(arrayasignacionif[0]);
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (salir.IsMatch(nuevocodigo[controladordenuevo])) {
        Environment.Exit(69);
    }
    else if (sleep.IsMatch(nuevocodigo[controladordenuevo])) {
        var varibleabuscar = nuevocodigo[controladordenuevo].Replace("çlbv", "");

        if (varibleabuscar[0].ToString().Contains("k")) {
            Thread.Sleep(int.Parse(k.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("l")) {
            Thread.Sleep(int.Parse(l.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("m")) {
            Thread.Sleep(int.Parse(m.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("n")) {
            Thread.Sleep(int.Parse(n.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("ñ")) {
            Thread.Sleep(int.Parse(ñ.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("o")) {
            Thread.Sleep(int.Parse(o.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("p")) {
            Thread.Sleep(int.Parse(p.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("q")) {
            Thread.Sleep(int.Parse(q.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("r")) {
            Thread.Sleep(int.Parse(r.ToString()));
        }
        else if (varibleabuscar[0].ToString().Contains("s")) {
            Thread.Sleep(int.Parse(s.ToString()));
        }
        else {
            throw new Exception();
        };
    }
    else if (invertirbool.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableainvertir = nuevocodigo[controladordenuevo].Replace("!7;", "");
        if (variableainvertir[0].ToString().Contains("w")) {
            w = !w;
        }
        else if (variableainvertir[0].ToString().Contains("x")) {
            x = !x;
        }
        else if (variableainvertir[0].ToString().Contains("y")) {
            y = !y;
        }
        else if (variableainvertir[0].ToString().Contains("z")) {
            z = !z;
        }
        else {
            throw new Exception();
        };
    }
    else if (restare.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r - numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s - numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (sumedore.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableaferificar = nuevocodigo[controladordenuevo][0];
        var numeroparalamodificacion = int.Parse(nuevocodigo[controladordenuevo].Substring("__RPD.".Length));
        if (variableaferificar.ToString().Contains("k")) {
            k = k + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("l")) {
            l = l + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("m")) {
            m = m + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("n")) {
            n = n + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("ñ")) {
            ñ = ñ + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("o")) {
            o = o + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("p")) {
            p = p + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("q")) {
            q = q + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("r")) {
            r = r + numeroparalamodificacion;
        }
        else if (variableaferificar.ToString().Contains("s")) {
            s = s + numeroparalamodificacion;
        }
        else {
            throw new Exception();
        };
    }
    else if (consolaentrada.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparalacomprobacion = nuevocodigo[controladordenuevo][0];
        if (variableparalacomprobacion.ToString().Contains("a")) {
            a = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("b")) {
            b = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("c")) {
            c = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("d")) {
            d = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("e")) {
            e = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("f")) {
            f = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("g")) {
            g = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("h")) {
            h = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("i")) {
            i = Console.ReadLine();
        }
        else if (variableparalacomprobacion.ToString().Contains("j")) {
            j = Console.ReadLine();
        }
        else {
            throw new Exception();
        };
    }
    else if (remplazar.IsMatch(nuevocodigo[controladordenuevo])) {
        var argumentos = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        string texto;
        string remplazo;
        var exp = new Regex(argumentos[1]);
        if (argumentos[0][0].ToString().Contains("a")) {
            texto = a;
        }
        else if (argumentos[0][0].ToString().Contains("b")) {
            texto = b;
        }
        else if (argumentos[0][0].ToString().Contains("c")) {
            texto = c;
        }
        else if (argumentos[0][0].ToString().Contains("d")) {
            texto = d;
        }
        else if (argumentos[0][0].ToString().Contains("e")) {
            texto = e;
        }
        else if (argumentos[0][0].ToString().Contains("f")) {
            texto = f;
        }
        else if (argumentos[0][0].ToString().Contains("g")) {
            texto = g;
        }
        else if (argumentos[0][0].ToString().Contains("h")) {
            texto = h;
        }
        else if (argumentos[0][0].ToString().Contains("i")) {
            texto = i;
        }
        else if (argumentos[0][0].ToString().Contains("j")) {
            texto = j;
        }
        else {
            throw new Exception();
        };


        if (argumentos[2][0].ToString().Contains("a")) {
            remplazo = a;
        }
        else if (argumentos[2][0].ToString().Contains("b")) {
            remplazo = b;
        }
        else if (argumentos[2][0].ToString().Contains("c")) {
            remplazo = c;
        }
        else if (argumentos[2][0].ToString().Contains("d")) {
            remplazo = d;
        }
        else if (argumentos[2][0].ToString().Contains("e")) {
            remplazo = e;
        }
        else if (argumentos[2][0].ToString().Contains("f")) {
            remplazo = f;
        }
        else if (argumentos[2][0].ToString().Contains("g")) {
            remplazo = g;
        }
        else if (argumentos[2][0].ToString().Contains("h")) {
            remplazo = h;
        }
        else if (argumentos[2][0].ToString().Contains("i")) {
            remplazo = i;
        }
        else if (argumentos[2][0].ToString().Contains("j")) {
            remplazo = j;
        }
        else {
            throw new Exception();
        };

        var resultado = exp.Replace(texto, remplazo);

        if (argumentos[3][0].ToString().Contains("a")) {
            a = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("b")) {
            b = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("c")) {
            c = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("d")) {
            d = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("e")) {
            e = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("f")) {
            f = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("g")) {
            g = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("h")) {
            h = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("i")) {
            i = resultado;
        }
        else if (argumentos[3][0].ToString().Contains("j")) {
            j = resultado;
        }
        else {
            throw new Exception();
        };

    }//
    else if (match.IsMatch(nuevocodigo[controladordenuevo])) {
        var args = nuevocodigo[controladordenuevo].Substring(4).Split('_');
        var expjaja = new Regex(args[0]);
        bool ismatch;

        if (args[1][0].ToString().Contains("a")) {
            if (expjaja.IsMatch(a)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("b")) {
            if (expjaja.IsMatch(b)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("c")) {
            if (expjaja.IsMatch(c)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("d")) {
            if (expjaja.IsMatch(d)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("e")) {
            if (expjaja.IsMatch(e)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("f")) {
            if (expjaja.IsMatch(f)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("g")) {
            if (expjaja.IsMatch(g)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("h")) {
            if (expjaja.IsMatch(h)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("i")) {
            if (expjaja.IsMatch(i)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else if (args[1][0].ToString().Contains("j")) {
            if (expjaja.IsMatch(j)) {
                ismatch = true;
            }
            else {
                ismatch = false;
            };
        }
        else {
            throw new Exception();
        };

        if (args[2][0].ToString().Contains("w")) {
            w = ismatch;
        }
        else if (args[2][0].ToString().Contains("x")) {
            x = ismatch;
        }
        else if (args[2][0].ToString().Contains("y")) {
            y = ismatch;
        }
        else if (args[2][0].ToString().Contains("z")) {
            z = ismatch;
        }
        else {
            throw new Exception();
        };

    }////////////////
    else if (editarchivus.IsMatch(nuevocodigo[controladordenuevo])) {
        var arrayedit = nuevocodigo[controladordenuevo].Replace("👌👈", "�").Split('�');
        if (File.Exists(arrayedit[0])) {
            if (arrayedit[1][0].ToString().Contains("a")) {
                File.WriteAllText(arrayedit[0], a);
            }
            else if (arrayedit[1][0].ToString().Contains("b")) {
                File.WriteAllText(arrayedit[0], b);
            }
            else if (arrayedit[1][0].ToString().Contains("c")) {
                File.WriteAllText(arrayedit[0], c);
            }
            else if (arrayedit[1][0].ToString().Contains("d")) {
                File.WriteAllText(arrayedit[0], d);
            }
            else if (arrayedit[1][0].ToString().Contains("e")) {
                File.WriteAllText(arrayedit[0], e);
            }
            else if (arrayedit[1][0].ToString().Contains("f")) {
                File.WriteAllText(arrayedit[0], f);
            }
            else if (arrayedit[1][0].ToString().Contains("g")) {
                File.WriteAllText(arrayedit[0], g);
            }
            else if (arrayedit[1][0].ToString().Contains("h")) {
                File.WriteAllText(arrayedit[0], h);
            }
            else if (arrayedit[1][0].ToString().Contains("i")) {
                File.WriteAllText(arrayedit[0], i);
            }
            else if (arrayedit[1][0].ToString().Contains("j")) {
                File.WriteAllText(arrayedit[0], j);
            }
            else {
                throw new Exception();
            };
        }
        else {
            throw new Exception();
        };
    }
    else if (concact.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaconcact = nuevocodigo[controladordenuevo].Replace("-/aa", "").Split('#');
        string concat1;
        string concat2;
        if (divicionparaconcact[0].ToString().Contains("a")) {
            concat1 = a;
        }
        else if (divicionparaconcact[0].ToString().Contains("b")) {
            concat1 = b;
        }
        else if (divicionparaconcact[0].ToString().Contains("c")) {
            concat1 = c;
        }
        else if (divicionparaconcact[0].ToString().Contains("d")) {
            concat1 = d;
        }
        else if (divicionparaconcact[0].ToString().Contains("e")) {
            concat1 = e;
        }
        else if (divicionparaconcact[0].ToString().Contains("f")) {
            concat1 = f;
        }
        else if (divicionparaconcact[0].ToString().Contains("g")) {
            concat1 = g;
        }
        else if (divicionparaconcact[0].ToString().Contains("h")) {
            concat1 = h;
        }
        else if (divicionparaconcact[0].ToString().Contains("i")) {
            concat1 = i;
        }
        else if (divicionparaconcact[0].ToString().Contains("j")) {
            concat1 = j;
        }
        else {
            throw new Exception();
        };


        if (divicionparaconcact[1].ToString().Contains("a")) {
            concat2 = a;
        }
        else if (divicionparaconcact[1].ToString().Contains("b")) {
            concat2 = b;
        }
        else if (divicionparaconcact[1].ToString().Contains("c")) {
            concat2 = c;
        }
        else if (divicionparaconcact[1].ToString().Contains("d")) {
            concat2 = d;
        }
        else if (divicionparaconcact[1].ToString().Contains("e")) {
            concat2 = e;
        }
        else if (divicionparaconcact[1].ToString().Contains("f")) {
            concat2 = f;
        }
        else if (divicionparaconcact[1].ToString().Contains("g")) {
            concat2 = g;
        }
        else if (divicionparaconcact[1].ToString().Contains("h")) {
            concat2 = h;
        }
        else if (divicionparaconcact[1].ToString().Contains("i")) {
            concat2 = i;
        }
        else if (divicionparaconcact[1].ToString().Contains("j")) {
            concat2 = j;
        }
        else {
            throw new Exception();
        };

        var posta = concat1 + concat2;

        if (divicionparaconcact[2].ToString().Contains("a")) {
            a = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("b")) {
            b = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("c")) {
            c = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("d")) {
            d = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("e")) {
            e = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("f")) {
            f = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("g")) {
            g = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("h")) {
            h = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("i")) {
            i = posta;
        }
        else if (divicionparaconcact[2].ToString().Contains("j")) {
            j = posta;
        }
        else {
            throw new Exception();
        };

        /////////////////
    }
    else if (controldetamaño.IsMatch(nuevocodigo[controladordenuevo])) {
        var controldetamañodivicion = nuevocodigo[controladordenuevo].Replace("gg", "").Split('¿');
        string textocontrol;

        if (controldetamañodivicion[0].ToString().Contains("a")) {
            textocontrol = a;
        }
        else if (controldetamañodivicion[0].ToString().Contains("b")) {
            textocontrol = b;
        }
        else if (controldetamañodivicion[0].ToString().Contains("c")) {
            textocontrol = c;
        }
        else if (controldetamañodivicion[0].ToString().Contains("d")) {
            textocontrol = d;
        }
        else if (controldetamañodivicion[0].ToString().Contains("e")) {
            textocontrol = e;
        }
        else if (controldetamañodivicion[0].ToString().Contains("f")) {
            textocontrol = f;
        }
        else if (controldetamañodivicion[0].ToString().Contains("g")) {
            textocontrol = g;
        }
        else if (controldetamañodivicion[0].ToString().Contains("h")) {
            textocontrol = h;
        }
        else if (controldetamañodivicion[0].ToString().Contains("i")) {
            textocontrol = i;
        }
        else if (controldetamañodivicion[0].ToString().Contains("j")) {
            textocontrol = j;
        }
        else {
            throw new Exception();
        };
        double primero;
        double segundo;

        if (controldetamañodivicion[1].ToString().Contains("k")) {
            primero = k;
        }
        else if (controldetamañodivicion[1].ToString().Contains("l")) {
            primero = l;
        }
        else if (controldetamañodivicion[1].ToString().Contains("m")) {
            primero = m;
        }
        else if (controldetamañodivicion[1].ToString().Contains("n")) {
            primero = n;
        }
        else if (controldetamañodivicion[1].ToString().Contains("ñ")) {
            primero = ñ;
        }
        else if (controldetamañodivicion[1].ToString().Contains("o")) {
            primero = o;
        }
        else if (controldetamañodivicion[1].ToString().Contains("p")) {
            primero = p;
        }
        else if (controldetamañodivicion[1].ToString().Contains("q")) {
            primero = q;
        }
        else if (controldetamañodivicion[1].ToString().Contains("r")) {
            primero = r;
        }
        else if (controldetamañodivicion[1].ToString().Contains("s")) {
            primero = s;
        }
        else {
            throw new Exception();
        };

        if (controldetamañodivicion[2].ToString().Contains("k")) {
            segundo = k;
        }
        else if (controldetamañodivicion[2].ToString().Contains("l")) {
            segundo = l;
        }
        else if (controldetamañodivicion[2].ToString().Contains("m")) {
            segundo = m;
        }
        else if (controldetamañodivicion[2].ToString().Contains("n")) {
            segundo = n;
        }
        else if (controldetamañodivicion[2].ToString().Contains("ñ")) {
            segundo = ñ;
        }
        else if (controldetamañodivicion[2].ToString().Contains("o")) {
            segundo = o;
        }
        else if (controldetamañodivicion[2].ToString().Contains("p")) {
            segundo = p;
        }
        else if (controldetamañodivicion[2].ToString().Contains("q")) {
            segundo = q;
        }
        else if (controldetamañodivicion[2].ToString().Contains("r")) {
            segundo = r;
        }
        else if (controldetamañodivicion[2].ToString().Contains("s")) {
            segundo = s;
        }
        else {
            throw new Exception();
        };

        var controlado = textocontrol.Substring(int.Parse(primero.ToString()), int.Parse(segundo.ToString()));

        if (controldetamañodivicion[3][0].ToString().Contains("a")) {
            a = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("b")) {
            b = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("c")) {
            c = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("d")) {
            d = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("e")) {
            e = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("f")) {
            f = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("g")) {
            g = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("h")) {
            h = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("i")) {
            i = controlado;
        }
        else if (controldetamañodivicion[3][0].ToString().Contains("j")) {
            j = controlado;
        }
        else {
            throw new Exception();
        };

        /////////
    }
    else if (intparse.IsMatch(nuevocodigo[controladordenuevo])) {
        var variableparaint = nuevocodigo[controladordenuevo].Replace("☺", "").Replace("♥☻", "�").Split('�');
        string aint;


        if (variableparaint[0][0].ToString().Contains("a")) {
            aint = a;
        }
        else if (variableparaint[0][0].ToString().Contains("b")) {
            aint = b;
        }
        else if (variableparaint[0][0].ToString().Contains("c")) {
            aint = c;
        }
        else if (variableparaint[0][0].ToString().Contains("d")) {
            aint = d;
        }
        else if (variableparaint[0][0].ToString().Contains("e")) {
            aint = e;
        }
        else if (variableparaint[0][0].ToString().Contains("f")) {
            aint = f;
        }
        else if (variableparaint[0][0].ToString().Contains("g")) {
            aint = g;
        }
        else if (variableparaint[0][0].ToString().Contains("h")) {
            aint = h;
        }
        else if (variableparaint[0][0].ToString().Contains("i")) {
            aint = i;
        }
        else if (variableparaint[0][0].ToString().Contains("j")) {
            aint = j;
        }
        else {
            throw new Exception();
        };

        if (variableparaint[1][0].ToString().Contains("k")) {
            k = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("l")) {
            l = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("m")) {
            m = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("n")) {
            n = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("ñ")) {
            ñ = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("o")) {
            o = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("p")) {
            p = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("q")) {
            q = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("r")) {
            r = Double.Parse(aint);
        }
        else if (variableparaint[1][0].ToString().Contains("s")) {
            s = Double.Parse(aint);
        }
        else {
            throw new Exception();
        };
        ///////////////
    }
    else if (reset.IsMatch(nuevocodigo[controladordenuevo])) {
        var resetdivicion = nuevocodigo[controladordenuevo].Replace("ñpqq", "");

        if (resetdivicion[0].ToString().Contains("k")) {
            xxx = int.Parse(k.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("l")) {
            xxx = int.Parse(l.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("m")) {
            xxx = int.Parse(m.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("n")) {
            xxx = int.Parse(n.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("ñ")) {
            xxx = int.Parse(ñ.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("o")) {
            xxx = int.Parse(o.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("p")) {
            xxx = int.Parse(p.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("q")) {
            xxx = int.Parse(q.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("r")) {
            xxx = int.Parse(r.ToString());
        }
        else if (resetdivicion[0].ToString().Contains("s")) {
            xxx = int.Parse(s.ToString());
        }
        else {
            throw new Exception();
        };
        //////
    }
    else if (exec.IsMatch(nuevocodigo[controladordenuevo])) {
        var divicionparaexec = nuevocodigo[controladordenuevo].Replace("yyyy", "").Split('@');
        string archivoexec;
        string argumentosexec;
        var proseso = new Process();
        if (divicionparaexec[0][0].ToString().Contains("a")) {
            archivoexec = a;
        }
        else if (divicionparaexec[0][0].ToString().Contains("b")) {
            archivoexec = b;
        }
        else if (divicionparaexec[0][0].ToString().Contains("c")) {
            archivoexec = c;
        }
        else if (divicionparaexec[0][0].ToString().Contains("d")) {
            archivoexec = d;
        }
        else if (divicionparaexec[0][0].ToString().Contains("e")) {
            archivoexec = e;
        }
        else if (divicionparaexec[0][0].ToString().Contains("f")) {
            archivoexec = f;
        }
        else if (divicionparaexec[0][0].ToString().Contains("g")) {
            archivoexec = g;
        }
        else if (divicionparaexec[0][0].ToString().Contains("h")) {
            archivoexec = h;
        }
        else if (divicionparaexec[0][0].ToString().Contains("i")) {
            archivoexec = i;
        }
        else if (divicionparaexec[0][0].ToString().Contains("j")) {
            archivoexec = j;
        }
        else {
            archivoexec = divicionparaexec[0];
        };

        if (divicionparaexec[1][0].ToString().Contains("a")) {
            argumentosexec = a;
        }
        else if (divicionparaexec[1][0].ToString().Contains("b")) {
            argumentosexec = b;
        }
        else if (divicionparaexec[1][0].ToString().Contains("c")) {
            argumentosexec = c;
        }
        else if (divicionparaexec[1][0].ToString().Contains("d")) {
            argumentosexec = d;
        }
        else if (divicionparaexec[1][0].ToString().Contains("e")) {
            argumentosexec = e;
        }
        else if (divicionparaexec[1][0].ToString().Contains("f")) {
            argumentosexec = f;
        }
        else if (divicionparaexec[1][0].ToString().Contains("g")) {
            argumentosexec = g;
        }
        else if (divicionparaexec[1][0].ToString().Contains("h")) {
            argumentosexec = h;
        }
        else if (divicionparaexec[1][0].ToString().Contains("i")) {
            argumentosexec = i;
        }
        else if (divicionparaexec[1][0].ToString().Contains("j")) {
            argumentosexec = j;
        }
        else {
            argumentosexec = divicionparaexec[1];
        };

        proseso.StartInfo.FileName = archivoexec;
        proseso.StartInfo.Arguments = argumentosexec;
        proseso.StartInfo.RedirectStandardOutput = true;
        proseso.StartInfo.RedirectStandardError = true;
                                            proseso.StartInfo.UseShellExecute = false;
                                            //proseso.ErrorDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };
                                            //proseso.OutputDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };

                                            if (divicionparaexec[2][0].ToString().Contains("a")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("b")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("c")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("d")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("e")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("f")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("g")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("h")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("i")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
        }
        else if (divicionparaexec[2][0].ToString().Contains("j")) {
            proseso.ErrorDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
            proseso.OutputDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
        }
        else {
            throw new Exception();
        };


        proseso.Start();
        /////////
    }//////////
    else {
        throw new Exception();
    };
};

                                };
                            }
                            else
                            {
                                throw new Exception();
                            };

                        };

                    }
                    else if (consola.IsMatch(diviciondecodigo[xxx]))
                    {
                        var variablus = diviciondecodigo[xxx].Replace("↓ùp👌", "");
                        //Console.WriteLine(variablus.Length);
                        if (variablus[0].ToString().Contains("a"))
                        {
                            Console.WriteLine(a);
                        }
                        else if (variablus[0].ToString().Contains("b"))
                        {
                            Console.WriteLine(b);
                        }
                        else if (variablus[0].ToString().Contains("c"))
                        {
                            Console.WriteLine(c);
                        }
                        else if (variablus[0].ToString().Contains("d"))
                        {
                            Console.WriteLine(d);
                        }
                        else if (variablus[0].ToString().Contains("e"))
                        {
                            Console.WriteLine(e);
                        }
                        else if (variablus[0].ToString().Contains("f"))
                        {
                            Console.WriteLine(f);
                        }
                        else if (variablus[0].ToString().Contains("g"))
                        {
                            Console.WriteLine(g);
                        }
                        else if (variablus[0].ToString().Contains("h"))
                        {
                            Console.WriteLine(h);
                        }
                        else if (variablus[0].ToString().Contains("i"))
                        {
                            Console.WriteLine(i);
                        }
                        else if (variablus[0].ToString().Contains("j"))
                        {
                            Console.WriteLine(j);
                        }
                        else if (variablus[0].ToString().Contains("k"))
                        {
                            Console.WriteLine(k);
                        }
                        else if (variablus[0].ToString().Contains("l"))
                        {
                            Console.WriteLine(l);
                        }
                        else if (variablus[0].ToString().Contains("m"))
                        {
                            Console.WriteLine(m);
                        }
                        else if (variablus[0].ToString().Contains("n"))
                        {
                            Console.WriteLine(n);
                        }
                        else if (variablus[0].ToString().Contains("ñ"))
                        {
                            Console.WriteLine(ñ);
                        }
                        else if (variablus[0].ToString().Contains("o"))
                        {
                            Console.WriteLine(o);
                        }
                        else if (variablus[0].ToString().Contains("p"))
                        {
                            Console.WriteLine(p);
                        }
                        else if (variablus[0].ToString().Contains("q"))
                        {
                            Console.WriteLine(q);
                        }
                        else if (variablus[0].ToString().Contains("r"))
                        {
                            Console.WriteLine(r);
                        }
                        else if (variablus[0].ToString().Contains("s"))
                        {
                            Console.WriteLine(s);
                        }
                        else if (variablus[0].ToString().Contains("t"))
                        {
                            var numero = variablus.Replace("-_-", "�").Split('�');
                            //Console.WriteLine(variablus[1]);
                            var consolear = t[int.Parse(numero[1].ToString())];
                            Console.WriteLine(consolear);
                        }
                        else if (variablus[0].ToString().Contains("u"))
                        {
                            var numero = variablus.Replace("-_-", "�").Split('�');
                            var consolear = u[int.Parse(numero[1].ToString())];
                            Console.WriteLine(consolear);
                        }
                        else if (variablus[0].ToString().Contains("v"))
                        {
                            var numero = variablus.Replace("-_-", "�").Split('�');
                            var consolear = v[int.Parse(numero[1].ToString())];
                            Console.WriteLine(consolear);
                        }
                        else if (variablus[0].ToString().Contains("w"))
                        {
                            Console.WriteLine(w);
                        }
                        else if (variablus[0].ToString().Contains("x"))
                        {
                            Console.WriteLine(x);
                        }
                        else if (variablus[0].ToString().Contains("y"))
                        {
                            Console.WriteLine(y);
                        }
                        else if (variablus[0].ToString().Contains("z"))
                        {
                            Console.WriteLine(z);
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }
                    else if (archivus.IsMatch(diviciondecodigo[xxx]))
                    {
                        var divicionenaccion = diviciondecodigo[xxx].Replace("csis", "�").Split('�');
                        if (File.Exists(divicionenaccion[0].Substring(3)))
                        {
                            var txt = File.ReadAllText(divicionenaccion[0].Substring(3));
                            if (divicionenaccion[1].ToString().Contains("a"))
                            {
                                a = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("b"))
                            {
                                b = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("c"))
                            {
                                c = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("d"))
                            {
                                d = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("e"))
                            {
                                e = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("f"))
                            {
                                f = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("g"))
                            {
                                g = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("h"))
                            {
                                h = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("i"))
                            {
                                i = txt;
                            }
                            else if (divicionenaccion[1].ToString().Contains("j"))
                            {
                                j = txt;
                            }
                            else
                            {
                                throw new Exception();
                            };
                        }
                        else
                        {
                            //Console.WriteLine(divicionenaccion[0]);
                            throw new Exception();
                        };
                    }
                    else if (http.IsMatch(diviciondecodigo[xxx]))
                    {
                        var link = diviciondecodigo[xxx].Split('¿')[1];
                        if (link.Length == 1)
                        {
                            if (link[0].ToString().Contains("a"))
                            {
                                link = a;
                            }
                            else if (link[0].ToString().Contains("b"))
                            {
                                link = b;
                            }
                            else if (link[0].ToString().Contains("c"))
                            {
                                link = c;
                            }
                            else if (link[0].ToString().Contains("d"))
                            {
                                link = d;
                            }
                            else if (link[0].ToString().Contains("e"))
                            {
                                link = e;
                            }
                            else if (link[0].ToString().Contains("f"))
                            {
                                link = f;
                            }
                            else if (link[0].ToString().Contains("g"))
                            {
                                link = g;
                            }
                            else if (link[0].ToString().Contains("h"))
                            {
                                link = h;
                            }
                            else if (link[0].ToString().Contains("i"))
                            {
                                link = i;
                            }
                            else if (link[0].ToString().Contains("j"))
                            {
                                link = j;
                            };
                        };
                        var conexion = new HttpClient();
                        conexion.DefaultRequestHeaders.Add("Authorization", diviciondecodigo[xxx].Split('¿')[2]);
                        //conexion.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", diviciondecodigo[xxx].Split('¿')[4].Substring(0, diviciondecodigo[xxx].Split('¿')[4].Length - 1));
                        //conexion.DefaultRequestHeaders.Add("Authorization", diviciondecodigo[xxx].Split('¿')[2]);//.Substring(0, diviciondecodigo[xxx].Split('¿')[2].Length - 1));
                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                        HttpResponseMessage pagina;

                        if (diviciondecodigo[xxx].Split('¿')[3].ToLower().Contains("get"))
                        {
                            pagina = await conexion.GetAsync(link);
                        }
                        else if (diviciondecodigo[xxx].Split('¿')[3].ToLower().Contains("delete"))
                        {
                            pagina = await conexion.DeleteAsync(link);
                        }
                        else if (diviciondecodigo[xxx].Split('¿')[3].Split('|')[0].ToLower().Contains("post"))
                        {
                            var peticion = new HttpRequestMessage();
                            peticion.Method = System.Net.Http.HttpMethod.Post;
                            conexion.BaseAddress = new Uri(link);
                            peticion.Headers.Add("Authorization", diviciondecodigo[xxx].Split('¿')[2]);
                            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, diviciondecodigo[xxx].Split('¿')[4].Substring(0, diviciondecodigo[xxx].Split('¿')[4].Length - 1));
                            var contenidoss = diviciondecodigo[xxx].Split('¿')[3].Split('|')[1];
                            if (contenidoss.Length == 1)
                            {
                                if (contenidoss[0].ToString().Contains("a"))
                                {
                                    contenidoss = a;
                                }
                                else if (contenidoss[0].ToString().Contains("b"))
                                {
                                    contenidoss = b;
                                }
                                else if (contenidoss[0].ToString().Contains("c"))
                                {
                                    contenidoss = c;
                                }
                                else if (contenidoss[0].ToString().Contains("d"))
                                {
                                    contenidoss = d;
                                }
                                else if (contenidoss[0].ToString().Contains("e"))
                                {
                                    contenidoss = e;
                                }
                                else if (contenidoss[0].ToString().Contains("f"))
                                {
                                    contenidoss = f;
                                }
                                else if (contenidoss[0].ToString().Contains("g"))
                                {
                                    contenidoss = g;
                                }
                                else if (contenidoss[0].ToString().Contains("h"))
                                {
                                    contenidoss = h;
                                }
                                else if (contenidoss[0].ToString().Contains("i"))
                                {
                                    contenidoss = i;
                                }
                                else if (contenidoss[0].ToString().Contains("j"))
                                {
                                    contenidoss = j;
                                };
                            };

                            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, diviciondecodigo[xxx].Split('¿')[3].Split('|')[2].Substring(0, diviciondecodigo[xxx].Split('¿')[3].Split('|')[2].Length - 1));


                            pagina = await conexion.SendAsync(peticion);
                        }
                        else if (diviciondecodigo[xxx].Split('¿')[3].Split('|')[0].ToLower().Contains("put"))
                        {
                            var peticion = new HttpRequestMessage();
                            peticion.Method = System.Net.Http.HttpMethod.Put;
                            conexion.BaseAddress = new Uri(link);
                            peticion.Headers.Add("Authorization", diviciondecodigo[xxx].Split('¿')[2]);
                            //peticion.Content = new StringContent("", System.Text.Encoding.UTF8, diviciondecodigo[xxx].Split('¿')[4].Substring(0, diviciondecodigo[xxx].Split('¿')[4].Length - 1));
                            var contenidoss = diviciondecodigo[xxx].Split('¿')[3].Split('|')[1];
                            if (contenidoss.Length == 1)
                            {
                                if (contenidoss[0].ToString().Contains("a"))
                                {
                                    contenidoss = a;
                                }
                                else if (contenidoss[0].ToString().Contains("b"))
                                {
                                    contenidoss = b;
                                }
                                else if (contenidoss[0].ToString().Contains("c"))
                                {
                                    contenidoss = c;
                                }
                                else if (contenidoss[0].ToString().Contains("d"))
                                {
                                    contenidoss = d;
                                }
                                else if (contenidoss[0].ToString().Contains("e"))
                                {
                                    contenidoss = e;
                                }
                                else if (contenidoss[0].ToString().Contains("f"))
                                {
                                    contenidoss = f;
                                }
                                else if (contenidoss[0].ToString().Contains("g"))
                                {
                                    contenidoss = g;
                                }
                                else if (contenidoss[0].ToString().Contains("h"))
                                {
                                    contenidoss = h;
                                }
                                else if (contenidoss[0].ToString().Contains("i"))
                                {
                                    contenidoss = i;
                                }
                                else if (contenidoss[0].ToString().Contains("j"))
                                {
                                    contenidoss = j;
                                };
                            };

                            peticion.Content = new StringContent(contenidoss, System.Text.Encoding.UTF8, diviciondecodigo[xxx].Split('¿')[3].Split('|')[2].Substring(0, diviciondecodigo[xxx].Split('¿')[3].Split('|')[2].Length - 1));


                            pagina = await conexion.SendAsync(peticion);
                        }
                        else
                        {
                            throw new Exception();
                            //pagina = await conexion.PutAsync(new Uri(link), new StringContent(diviciondecodigo[xxx].Split('¿')[3].Split('|')[1]));
                        };


                        // = await conexion.GetAsync(link);
                        //pagina.EnsureSuccessStatusCode();
                        var html = await pagina.Content.ReadAsStringAsync();
                        var status1 = pagina.StatusCode.ToString();
                        Double status;
                        switch (status1)
                        {
                            case "Accepted":
                                status = 202;
                                break;
                            case "Ambiguous":
                                status = 300;
                                break;
                            case "BadGateway":
                                status = 502;
                                break;
                            case "BadRequest":
                                status = 400;
                                break;
                            case "Conflict":
                                status = 409;
                                break;
                            case "Continue":
                                status = 100;
                                break;
                            case "Created":
                                status = 201;
                                break;
                            case "ExpectationFailed":
                                status = 417;
                                break;
                            case "Forbidden":
                                status = 403;
                                break;
                            case "Found":
                                status = 302;
                                break;
                            case "GatewayTimeout":
                                status = 504;
                                break;
                            case "Gone":
                                status = 410;
                                break;
                            case "HttpVersionNotSupported":
                                status = 505;
                                break;
                            case "InternalServerError":
                                status = 500;
                                break;
                            case "LengthRequired":
                                status = 411;
                                break;
                            case "MethodNotAllowed":
                                status = 405;
                                break;
                            case "Moved":
                                status = 301;
                                break;
                            case "MovedPermanently":
                                status = 301;
                                break;
                            case "MultipleChoices":
                                status = 300;
                                break;
                            case "NoContent":
                                status = 204;
                                break;
                            case "NonAuthoritativeInformation":
                                status = 203;
                                break;
                            case "NotAcceptable":
                                status = 406;
                                break;
                            case "NotFound":
                                status = 404;
                                break;
                            case "NotImplemented":
                                status = 501;
                                break;
                            case "NotModified":
                                status = 304;
                                break;
                            case "OK":
                                status = 200;
                                break;
                            case "PartialContent":
                                status = 206;
                                break;
                            case "PaymentRequired":
                                status = 402;
                                break;
                            case "PreconditionFailed":
                                status = 412;
                                break;
                            case "ProxyAuthenticationRequired":
                                status = 407;
                                break;
                            case "Redirect":
                                status = 302;
                                break;
                            case "RedirectKeepVerb":
                                status = 307;
                                break;
                            case "RedirectMethod":
                                status = 303;
                                break;
                            case "RequestedRangeNotSatisfiable":
                                status = 416;
                                break;
                            case "RequestEntityTooLarge":
                                status = 413;
                                break;
                            case "RequestTimeout":
                                status = 408;
                                break;
                            case "RequestUriTooLong":
                                status = 414;
                                break;
                            case "ResetContent":
                                status = 205;
                                break;
                            case "SeeOther":
                                status = 303;
                                break;
                            case "ServiceUnavailable":
                                status = 503;
                                break;
                            case "SwitchingProtocols":
                                status = 101;
                                break;
                            case "TemporaryRedirect":
                                status = 307;
                                break;
                            case "Unauthorized":
                                status = 401;
                                break;
                            case "UnsupportedMediaType":
                                status = 415;
                                break;
                            case "Unused":
                                status = 306;
                                break;
                            case "UpgradeRequired":
                                status = 426;
                                break;
                            case "UseProxy":
                                status = 305;
                                break;
                            default:
                                throw new Exception();
                                break;
                        };
                        var varparaelstatus = diviciondecodigo[xxx].Split('¿')[0].Split('<')[1];
                        var varparalapagina = diviciondecodigo[xxx].Split('¿')[0].Split('<')[0].Replace("l},º", "");
                        switch (varparaelstatus)
                        {
                            case "k":
                                k = status;
                                break;
                            case "l":
                                l = status;
                                break;
                            case "m":
                                m = status;
                                break;
                            case "n":
                                n = status;
                                break;
                            case "ñ":
                                ñ = status;
                                break;
                            case "o":
                                o = status;
                                break;
                            case "p":
                                p = status;
                                break;
                            case "q":
                                q = status;
                                break;
                            case "r":
                                r = status;
                                break;
                            case "s":
                                s = status;
                                break;
                            default:
                                throw new Exception();
                                break;
                        };
                        switch (varparalapagina)
                        {
                            case "a":
                                a = html;
                                break;
                            case "b":
                                a = html;
                                break;
                            case "c":
                                a = html;
                                break;
                            case "d":
                                a = html;
                                break;
                            case "e":
                                a = html;
                                break;
                            case "f":
                                a = html;
                                break;
                            case "g":
                                a = html;
                                break;
                            case "h":
                                a = html;
                                break;
                            case "i":
                                a = html;
                                break;
                            case "j":
                                a = html;
                                break;
                            default:
                                throw new Exception();
                                break;
                        };

                    }
                    else if (cambiarvalor.IsMatch(diviciondecodigo[xxx]))
                    {



                        string[] arrayasignacion = diviciondecodigo[xxx].Replace("¨ç]", "�").Split('�');
                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacion[1]);

                        ///////////////////////////////////////////
                        //Console.WriteLine(arrayasignacion[1].Length);
                        var estoesarray = new Regex(".-_-.");
                        /*if(arrayasignacion[1].Length != 2 || arrayasignacion[1].Length != 1)
                        {
                            throw new Exception();
                        }*/
                        if (arrayasignacion[1][0].ToString().Contains("a"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    a = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                a = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("b"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    b = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                b = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("c"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    c = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                c = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("d"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    d = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                d = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("e"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    e = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                e = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("f"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    f = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                f = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("g"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    g = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                g = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("h"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    h = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                h = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("i"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    i = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                i = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("j"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("u"))
                                {
                                    j = u[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                j = arrayasignacion[0];
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("k")) ///los numeritos
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    k = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                k = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("l"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    l = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                l = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("m"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    m = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                m = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("n"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    n = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                n = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("ñ"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    ñ = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                ñ = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("o"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    o = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                o = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("p"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    p = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                p = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("q"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    q = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                q = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("r"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    r = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                r = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("s"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("t"))
                                {
                                    s = t[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                s = Double.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("t"))
                        {
                            var jajadivicion = arrayasignacion[0].Replace("º-/*", "�").Split('�');
                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                            {
                                if (jajadivicion[zzz].Contains("NaN"))
                                {
                                    throw new Exception();
                                }
                                t[zzz] = Double.Parse(jajadivicion[zzz]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("u"))
                        {
                            u = arrayasignacion[0].Replace("º-/*", "�").Split('�');
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("v"))
                        {
                            var jajadivicion2 = arrayasignacion[0].Replace("º-/*", "�").Split('�');
                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                            {
                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("w"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("v"))
                                {
                                    w = v[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                w = bool.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("x"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("v"))
                                {
                                    x = v[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                x = bool.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("y"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("v"))
                                {
                                    y = v[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                y = bool.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("z"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "�").Split('�');
                                if (divicionSuprema[0][0].ToString().Contains("v"))
                                {
                                    z = v[int.Parse(divicionSuprema[1])];
                                }
                                else
                                {
                                    throw new Exception();
                                };
                            }
                            else
                            {
                                //if (arrayasignacion[0] == "NaN") throw new Exception();
                                z = bool.Parse(arrayasignacion[0]);
                            };
                        }
                        else
                        {
                            throw new Exception();
                        };

                        ////////////////////////////////////////////////////////////////////////////
                        ///if (arrayasignacion[1].Contains("a")) { }
                        ///Console.WriteLine(arrayasignacion[1]);


                    }
                    else if (salir.IsMatch(diviciondecodigo[xxx]))
                    {
                        Environment.Exit(69);
                    }
                    else if (sleep.IsMatch(diviciondecodigo[xxx]))
                    {
                        var varibleabuscar = diviciondecodigo[xxx].Replace("çlbv", "");

                        if (varibleabuscar[0].ToString().Contains("k"))
                        {
                            Thread.Sleep(int.Parse(k.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("l"))
                        {
                            Thread.Sleep(int.Parse(l.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("m"))
                        {
                            Thread.Sleep(int.Parse(m.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("n"))
                        {
                            Thread.Sleep(int.Parse(n.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("ñ"))
                        {
                            Thread.Sleep(int.Parse(ñ.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("o"))
                        {
                            Thread.Sleep(int.Parse(o.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("p"))
                        {
                            Thread.Sleep(int.Parse(p.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("q"))
                        {
                            Thread.Sleep(int.Parse(q.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("r"))
                        {
                            Thread.Sleep(int.Parse(r.ToString()));
                        }
                        else if (varibleabuscar[0].ToString().Contains("s"))
                        {
                            Thread.Sleep(int.Parse(s.ToString()));
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }
                    else if (invertirbool.IsMatch(diviciondecodigo[xxx]))
                    {
                        var variableainvertir = diviciondecodigo[xxx].Replace("!7;", "");
                        if (variableainvertir[0].ToString().Contains("w"))
                        {
                            w = !w;
                        }
                        else if (variableainvertir[0].ToString().Contains("x"))
                        {
                            x = !x;
                        }
                        else if (variableainvertir[0].ToString().Contains("y"))
                        {
                            y = !y;
                        }
                        else if (variableainvertir[0].ToString().Contains("z"))
                        {
                            z = !z;
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }
                    else if (restare.IsMatch(diviciondecodigo[xxx]))
                    {
                        var variableaferificar = diviciondecodigo[xxx][0];
                        var numeroparalamodificacion = int.Parse(diviciondecodigo[xxx].Substring("__RPD.".Length));
                        if (variableaferificar.ToString().Contains("k"))
                        {
                            k = k - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("l"))
                        {
                            l = l - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("m"))
                        {
                            m = m - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("n"))
                        {
                            n = n - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("ñ"))
                        {
                            ñ = ñ - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("o"))
                        {
                            o = o - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("p"))
                        {
                            p = p - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("q"))
                        {
                            q = q - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("r"))
                        {
                            r = r - numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("s"))
                        {
                            s = s - numeroparalamodificacion;
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }
                    else if (sumedore.IsMatch(diviciondecodigo[xxx]))
                    {
                        var variableaferificar = diviciondecodigo[xxx][0];
                        var numeroparalamodificacion = int.Parse(diviciondecodigo[xxx].Substring("__RPD.".Length));
                        if (variableaferificar.ToString().Contains("k"))
                        {
                            k = k + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("l"))
                        {
                            l = l + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("m"))
                        {
                            m = m + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("n"))
                        {
                            n = n + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("ñ"))
                        {
                            ñ = ñ + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("o"))
                        {
                            o = o + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("p"))
                        {
                            p = p + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("q"))
                        {
                            q = q + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("r"))
                        {
                            r = r + numeroparalamodificacion;
                        }
                        else if (variableaferificar.ToString().Contains("s"))
                        {
                            s = s + numeroparalamodificacion;
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }
                    else if (consolaentrada.IsMatch(diviciondecodigo[xxx]))
                    {

                        var variableparalacomprobacion = diviciondecodigo[xxx][0];

                        if (variableparalacomprobacion.ToString().Contains("a"))
                        {
                            //Console.WriteLine(variableparalacomprobacion);
                            a = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("b"))
                        {
                            b = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("c"))
                        {
                            c = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("d"))
                        {
                            d = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("e"))
                        {
                            e = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("f"))
                        {
                            f = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("g"))
                        {
                            g = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("h"))
                        {
                            h = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("i"))
                        {
                            i = Console.ReadLine();
                        }
                        else if (variableparalacomprobacion.ToString().Contains("j"))
                        {
                            j = Console.ReadLine();
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }
                    else if (remplazar.IsMatch(diviciondecodigo[xxx]))
                    {
                        var argumentos = diviciondecodigo[xxx].Substring(4).Split('_');
                        string texto;
                        string remplazo;
                        var exp = new Regex(argumentos[1]);
                        if (argumentos[0][0].ToString().Contains("a"))
                        {
                            texto = a;
                        }
                        else if (argumentos[0][0].ToString().Contains("b"))
                        {
                            texto = b;
                        }
                        else if (argumentos[0][0].ToString().Contains("c"))
                        {
                            texto = c;
                        }
                        else if (argumentos[0][0].ToString().Contains("d"))
                        {
                            texto = d;
                        }
                        else if (argumentos[0][0].ToString().Contains("e"))
                        {
                            texto = e;
                        }
                        else if (argumentos[0][0].ToString().Contains("f"))
                        {
                            texto = f;
                        }
                        else if (argumentos[0][0].ToString().Contains("g"))
                        {
                            texto = g;
                        }
                        else if (argumentos[0][0].ToString().Contains("h"))
                        {
                            texto = h;
                        }
                        else if (argumentos[0][0].ToString().Contains("i"))
                        {
                            texto = i;
                        }
                        else if (argumentos[0][0].ToString().Contains("j"))
                        {
                            texto = j;
                        }
                        else
                        {
                            throw new Exception();
                        };


                        if (argumentos[2][0].ToString().Contains("a"))
                        {
                            remplazo = a;
                        }
                        else if (argumentos[2][0].ToString().Contains("b"))
                        {
                            remplazo = b;
                        }
                        else if (argumentos[2][0].ToString().Contains("c"))
                        {
                            remplazo = c;
                        }
                        else if (argumentos[2][0].ToString().Contains("d"))
                        {
                            remplazo = d;
                        }
                        else if (argumentos[2][0].ToString().Contains("e"))
                        {
                            remplazo = e;
                        }
                        else if (argumentos[2][0].ToString().Contains("f"))
                        {
                            remplazo = f;
                        }
                        else if (argumentos[2][0].ToString().Contains("g"))
                        {
                            remplazo = g;
                        }
                        else if (argumentos[2][0].ToString().Contains("h"))
                        {
                            remplazo = h;
                        }
                        else if (argumentos[2][0].ToString().Contains("i"))
                        {
                            remplazo = i;
                        }
                        else if (argumentos[2][0].ToString().Contains("j"))
                        {
                            remplazo = j;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        var resultado = exp.Replace(texto, remplazo);

                        if (argumentos[3][0].ToString().Contains("a"))
                        {
                            a = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("b"))
                        {
                            b = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("c"))
                        {
                            c = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("d"))
                        {
                            d = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("e"))
                        {
                            e = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("f"))
                        {
                            f = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("g"))
                        {
                            g = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("h"))
                        {
                            h = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("i"))
                        {
                            i = resultado;
                        }
                        else if (argumentos[3][0].ToString().Contains("j"))
                        {
                            j = resultado;
                        }
                        else
                        {
                            throw new Exception();
                        };

                    }
                    else if (match.IsMatch(diviciondecodigo[xxx]))
                    {
                        var args = diviciondecodigo[xxx].Substring(4).Split('_');
                        var expjaja = new Regex(args[0]);
                        bool ismatch;

                        if (args[1][0].ToString().Contains("a"))
                        {
                            if (expjaja.IsMatch(a))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("b"))
                        {
                            if (expjaja.IsMatch(b))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("c"))
                        {
                            if (expjaja.IsMatch(c))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("d"))
                        {
                            if (expjaja.IsMatch(d))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("e"))
                        {
                            if (expjaja.IsMatch(e))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("f"))
                        {
                            if (expjaja.IsMatch(f))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("g"))
                        {
                            if (expjaja.IsMatch(g))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("h"))
                        {
                            if (expjaja.IsMatch(h))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("i"))
                        {
                            if (expjaja.IsMatch(i))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else if (args[1][0].ToString().Contains("j"))
                        {
                            if (expjaja.IsMatch(j))
                            {
                                ismatch = true;
                            }
                            else
                            {
                                ismatch = false;
                            };
                        }
                        else
                        {
                            throw new Exception();
                        };

                        if (args[2][0].ToString().Contains("w"))
                        {
                            w = ismatch;
                        }
                        else if (args[2][0].ToString().Contains("x"))
                        {
                            x = ismatch;
                        }
                        else if (args[2][0].ToString().Contains("y"))
                        {
                            y = ismatch;
                        }
                        else if (args[2][0].ToString().Contains("z"))
                        {
                            z = ismatch;
                        }
                        else
                        {
                            throw new Exception();
                        };

                    }
                    else if (editarchivus.IsMatch(diviciondecodigo[xxx]))
                    {
                        var arrayedit = diviciondecodigo[xxx].Replace("👌👈", "�").Split('�');
                        if (File.Exists(arrayedit[0]))
                        {
                            if (arrayedit[1][0].ToString().Contains("a"))
                            {
                                File.WriteAllText(arrayedit[0], a);
                            }
                            else if (arrayedit[1][0].ToString().Contains("b"))
                            {
                                File.WriteAllText(arrayedit[0], b);
                            }
                            else if (arrayedit[1][0].ToString().Contains("c"))
                            {
                                File.WriteAllText(arrayedit[0], c);
                            }
                            else if (arrayedit[1][0].ToString().Contains("d"))
                            {
                                File.WriteAllText(arrayedit[0], d);
                            }
                            else if (arrayedit[1][0].ToString().Contains("e"))
                            {
                                File.WriteAllText(arrayedit[0], e);
                            }
                            else if (arrayedit[1][0].ToString().Contains("f"))
                            {
                                File.WriteAllText(arrayedit[0], f);
                            }
                            else if (arrayedit[1][0].ToString().Contains("g"))
                            {
                                File.WriteAllText(arrayedit[0], g);
                            }
                            else if (arrayedit[1][0].ToString().Contains("h"))
                            {
                                File.WriteAllText(arrayedit[0], h);
                            }
                            else if (arrayedit[1][0].ToString().Contains("i"))
                            {
                                File.WriteAllText(arrayedit[0], i);
                            }
                            else if (arrayedit[1][0].ToString().Contains("j"))
                            {
                                File.WriteAllText(arrayedit[0], j);
                            }
                            else
                            {
                                throw new Exception();
                            };
                        }
                        else
                        {
                            throw new Exception();
                        };
                    }////////////////x
                    else if (concact.IsMatch(diviciondecodigo[xxx]))
                    {
                        var divicionparaconcact = diviciondecodigo[xxx].Replace("-/aa", "").Split('#');
                        string concat1;
                        string concat2;
                        if (divicionparaconcact[0].ToString().Contains("a"))
                        {
                            concat1 = a;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("b"))
                        {
                            concat1 = b;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("c"))
                        {
                            concat1 = c;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("d"))
                        {
                            concat1 = d;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("e"))
                        {
                            concat1 = e;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("f"))
                        {
                            concat1 = f;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("g"))
                        {
                            concat1 = g;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("h"))
                        {
                            concat1 = h;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("i"))
                        {
                            concat1 = i;
                        }
                        else if (divicionparaconcact[0].ToString().Contains("j"))
                        {
                            concat1 = j;
                        }
                        else
                        {
                            throw new Exception();
                        };


                        if (divicionparaconcact[1].ToString().Contains("a"))
                        {
                            concat2 = a;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("b"))
                        {
                            concat2 = b;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("c"))
                        {
                            concat2 = c;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("d"))
                        {
                            concat2 = d;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("e"))
                        {
                            concat2 = e;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("f"))
                        {
                            concat2 = f;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("g"))
                        {
                            concat2 = g;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("h"))
                        {
                            concat2 = h;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("i"))
                        {
                            concat2 = i;
                        }
                        else if (divicionparaconcact[1].ToString().Contains("j"))
                        {
                            concat2 = j;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        var posta = concat1 + concat2;

                        if (divicionparaconcact[2].ToString().Contains("a"))
                        {
                            a = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("b"))
                        {
                            b = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("c"))
                        {
                            c = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("d"))
                        {
                            d = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("e"))
                        {
                            e = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("f"))
                        {
                            f = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("g"))
                        {
                            g = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("h"))
                        {
                            h = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("i"))
                        {
                            i = posta;
                        }
                        else if (divicionparaconcact[2].ToString().Contains("j"))
                        {
                            j = posta;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        /////////////////
                    }
                    else if (controldetamaño.IsMatch(diviciondecodigo[xxx]))
                    {
                        var controldetamañodivicion = diviciondecodigo[xxx].Replace("gg", "").Split('¿');
                        string textocontrol;

                        if (controldetamañodivicion[0].ToString().Contains("a"))
                        {
                            textocontrol = a;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("b"))
                        {
                            textocontrol = b;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("c"))
                        {
                            textocontrol = c;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("d"))
                        {
                            textocontrol = d;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("e"))
                        {
                            textocontrol = e;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("f"))
                        {
                            textocontrol = f;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("g"))
                        {
                            textocontrol = g;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("h"))
                        {
                            textocontrol = h;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("i"))
                        {
                            textocontrol = i;
                        }
                        else if (controldetamañodivicion[0].ToString().Contains("j"))
                        {
                            textocontrol = j;
                        }
                        else
                        {
                            throw new Exception();
                        };
                        double primero;
                        double segundo;

                        if (controldetamañodivicion[1].ToString().Contains("k"))
                        {
                            primero = k;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("l"))
                        {
                            primero = l;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("m"))
                        {
                            primero = m;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("n"))
                        {
                            primero = n;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("ñ"))
                        {
                            primero = ñ;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("o"))
                        {
                            primero = o;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("p"))
                        {
                            primero = p;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("q"))
                        {
                            primero = q;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("r"))
                        {
                            primero = r;
                        }
                        else if (controldetamañodivicion[1].ToString().Contains("s"))
                        {
                            primero = s;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        if (controldetamañodivicion[2].ToString().Contains("k"))
                        {
                            segundo = k;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("l"))
                        {
                            segundo = l;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("m"))
                        {
                            segundo = m;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("n"))
                        {
                            segundo = n;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("ñ"))
                        {
                            segundo = ñ;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("o"))
                        {
                            segundo = o;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("p"))
                        {
                            segundo = p;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("q"))
                        {
                            segundo = q;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("r"))
                        {
                            segundo = r;
                        }
                        else if (controldetamañodivicion[2].ToString().Contains("s"))
                        {
                            segundo = s;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        var controlado = textocontrol.Substring(int.Parse(primero.ToString()), int.Parse(segundo.ToString()));

                        if (controldetamañodivicion[3][0].ToString().Contains("a"))
                        {
                            a = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("b"))
                        {
                            b = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("c"))
                        {
                            c = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("d"))
                        {
                            d = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("e"))
                        {
                            e = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("f"))
                        {
                            f = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("g"))
                        {
                            g = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("h"))
                        {
                            h = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("i"))
                        {
                            i = controlado;
                        }
                        else if (controldetamañodivicion[3][0].ToString().Contains("j"))
                        {
                            j = controlado;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        /////////
                    }
                    else if (intparse.IsMatch(diviciondecodigo[xxx]))
                    {
                        var variableparaint = diviciondecodigo[xxx].Replace("☺", "").Replace("♥☻", "�").Split('�');
                        string aint;


                        if (variableparaint[0][0].ToString().Contains("a"))
                        {
                            aint = a;
                        }
                        else if (variableparaint[0][0].ToString().Contains("b"))
                        {
                            aint = b;
                        }
                        else if (variableparaint[0][0].ToString().Contains("c"))
                        {
                            aint = c;
                        }
                        else if (variableparaint[0][0].ToString().Contains("d"))
                        {
                            aint = d;
                        }
                        else if (variableparaint[0][0].ToString().Contains("e"))
                        {
                            aint = e;
                        }
                        else if (variableparaint[0][0].ToString().Contains("f"))
                        {
                            aint = f;
                        }
                        else if (variableparaint[0][0].ToString().Contains("g"))
                        {
                            aint = g;
                        }
                        else if (variableparaint[0][0].ToString().Contains("h"))
                        {
                            aint = h;
                        }
                        else if (variableparaint[0][0].ToString().Contains("i"))
                        {
                            aint = i;
                        }
                        else if (variableparaint[0][0].ToString().Contains("j"))
                        {
                            aint = j;
                        }
                        else
                        {
                            throw new Exception();
                        };

                        if (variableparaint[1][0].ToString().Contains("k"))
                        {
                            k = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("l"))
                        {
                            l = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("m"))
                        {
                            m = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("n"))
                        {
                            n = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("ñ"))
                        {
                            ñ = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("o"))
                        {
                            o = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("p"))
                        {
                            p = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("q"))
                        {
                            q = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("r"))
                        {
                            r = Double.Parse(aint);
                        }
                        else if (variableparaint[1][0].ToString().Contains("s"))
                        {
                            s = Double.Parse(aint);
                        }
                        else
                        {
                            throw new Exception();
                        };
                        ///////////////
                    }
                    else if (reset.IsMatch(diviciondecodigo[xxx]))
                    {
                        var resetdivicion = diviciondecodigo[xxx].Replace("ñpqq", "");

                        if (resetdivicion[0].ToString().Contains("k"))
                        {
                            xxx = int.Parse(k.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("l"))
                        {
                            xxx = int.Parse(l.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("m"))
                        {
                            xxx = int.Parse(m.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("n"))
                        {
                            xxx = int.Parse(n.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("ñ"))
                        {
                            xxx = int.Parse(ñ.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("o"))
                        {
                            xxx = int.Parse(o.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("p"))
                        {
                            xxx = int.Parse(p.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("q"))
                        {
                            xxx = int.Parse(q.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("r"))
                        {
                            xxx = int.Parse(r.ToString());
                        }
                        else if (resetdivicion[0].ToString().Contains("s"))
                        {
                            xxx = int.Parse(s.ToString());
                        }
                        else
                        {
                            throw new Exception();
                        };
                        //////
                    }
                    else if (exec.IsMatch(diviciondecodigo[xxx]))
                    {
                        var divicionparaexec = diviciondecodigo[xxx].Replace("yyyy", "").Split('@');
                        string archivoexec;
                        string argumentosexec;
                        var proseso = new Process();
                        if (divicionparaexec[0][0].ToString().Contains("a"))
                        {
                            archivoexec = a;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("b"))
                        {
                            archivoexec = b;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("c"))
                        {
                            archivoexec = c;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("d"))
                        {
                            archivoexec = d;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("e"))
                        {
                            archivoexec = e;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("f"))
                        {
                            archivoexec = f;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("g"))
                        {
                            archivoexec = g;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("h"))
                        {
                            archivoexec = h;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("i"))
                        {
                            archivoexec = i;
                        }
                        else if (divicionparaexec[0][0].ToString().Contains("j"))
                        {
                            archivoexec = j;
                        }
                        else
                        {
                            archivoexec = divicionparaexec[0];
                        };

                        if (divicionparaexec[1][0].ToString().Contains("a"))
                        {
                            argumentosexec = a;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("b"))
                        {
                            argumentosexec = b;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("c"))
                        {
                            argumentosexec = c;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("d"))
                        {
                            argumentosexec = d;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("e"))
                        {
                            argumentosexec = e;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("f"))
                        {
                            argumentosexec = f;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("g"))
                        {
                            argumentosexec = g;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("h"))
                        {
                            argumentosexec = h;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("i"))
                        {
                            argumentosexec = i;
                        }
                        else if (divicionparaexec[1][0].ToString().Contains("j"))
                        {
                            argumentosexec = j;
                        }
                        else
                        {
                            argumentosexec = divicionparaexec[1];
                        };

                        proseso.StartInfo.FileName = archivoexec;
                        proseso.StartInfo.Arguments = argumentosexec;
                        proseso.StartInfo.RedirectStandardOutput = true;
                        proseso.StartInfo.RedirectStandardError = true;
                        proseso.StartInfo.UseShellExecute = false;
                        //proseso.ErrorDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };
                        //proseso.OutputDataReceived += (ppp, pppp) => {a = pppp.Data.ToString(); };

                        if (divicionparaexec[2][0].ToString().Contains("a"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { a = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("b"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { b = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("c"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { c = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("d"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { d = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("e"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { e = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("f"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { f = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("g"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { g = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("h"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { h = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("i"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { i = pppp.Data.ToString(); };
                        }
                        else if (divicionparaexec[2][0].ToString().Contains("j"))
                        {
                            proseso.ErrorDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
                            proseso.OutputDataReceived += (ppp, pppp) => { j = pppp.Data.ToString(); };
                        }
                        else
                        {
                            throw new Exception();
                        };


                        proseso.Start();
                        /////////
                    }//////////
                    else
                    {
                        throw new Exception();
                    };
                };

                while (true) { };

            }
            catch (Exception x)
            {
                Console.Title = "Troll Online";
                Console.Clear();
                Console.WriteLine("Fracasaste, simplemento no pudiste usar este lenguaje, vuelve cuando seas un robot");
                Console.WriteLine(x);
                while (true) { };
            };
        }
    };
    class Program
    {

        //public void interprete(){}
        static async Task Main()
        {
            //Console.WriteLine("dsdsd".ToString());
            //var xs = new Compilador();
            //await xs.LOL();
            Console.Title = "Troll Online";
            var opciones = false;
            while (opciones == false)
            {
                var comando = Console.ReadLine().Replace(" ", "").Replace("\n", ""); //interpretar ejecutar [ruta] cerrar
                switch (comando)
                {
                    case "ejecutar":
                        opciones = true;
                        Console.WriteLine("Ingrese el archivo a ejecutar.");
                        var existencia = false;
                        var archivo = Console.ReadLine();

                        while (existencia == false)
                        {
                            if (File.Exists(archivo))
                            {
                                if (archivo.EndsWith(".tllonline"))
                                {
                                    var x = new Compilador();
                                    string codigos = File.ReadAllText(archivo);
                                    await x.SCompilador(codigos);
                                    existencia = true;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el archivo a ejecutar de extencion .tllonline.");
                                    Console.Beep();
                                    archivo = Console.ReadLine();
                                };
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el archivo a ejecutar.");
                                archivo = Console.ReadLine();
                            };
                        };
                        break;

                    case "salir":
                        Environment.Exit(69);
                        break;
                    default:
                        break;
                };
            };
        }
    }
}
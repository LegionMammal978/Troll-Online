using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;


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

                float k = 0;
                float l = 0;
                float m = 0;
                float n = 0;
                float ñ = 0;
                float o = 0;
                float p = 0;
                float q = 0;
                float r = 0;
                float s = 0;

                float[] t = new float[999999999];
                string[] u = new string[99999999];
                bool[] v = new bool[999999999];

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

                float buscarNumero()
                {

                };*/

                var cambiarvalor = new Regex(".+¨ç].+");
                var laif = new Regex(".¿!ª#.");
                var http = new Regex("^l},º.<.¿.+¿.+");
                var archivus = new Regex("^♫↕!.+csis.");
                var consola = new Regex("^↓ùp👌.");
                var bucle = new Regex("__rap.");

                for (var xxx = 0; xxx < diviciondecodigo.Length; xxx++)
                {


                    if (bucle.IsMatch(diviciondecodigo[xxx]))
                    {
                        var repeticiones = diviciondecodigo[xxx].Replace("__rap", "")[0].ToString();
                        if (repeticiones.Contains("k"))
                        {
                            var repeticionesGG = k;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("l"))
                        {
                            var repeticionesGG = l;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("m"))
                        {
                            var repeticionesGG = m;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("n"))
                        {
                            var repeticionesGG = n;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("ñ"))
                        {
                            var repeticionesGG = ñ;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("o"))
                        {
                            var repeticionesGG = o;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("p"))
                        {
                            var repeticionesGG = p;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("q"))
                        {
                            var repeticionesGG = q;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("r"))
                        {
                            var repeticionesGG = r;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        }
                        else if (repeticiones.Contains("s"))
                        {
                            var repeticionesGG = s;
                            for (int ddddd = 0; ddddd == repeticionesGG; ddddd++)
                            {
                                var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                {
                                    if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            //Console.WriteLine(variablus[1]);
                                            var consolear = t[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("u"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                            var consolear = u[int.Parse(numero[1].ToString())];
                                            Console.WriteLine(consolear);
                                        }
                                        else if (variablus[0].ToString().Contains("v"))
                                        {
                                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                    else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                    else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                    {
                                        var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                        var conexion = new HttpClient();
                                        conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                        var pagina = await conexion.GetAsync(link);
                                        //pagina.EnsureSuccessStatusCode();
                                        var html = await pagina.Content.ReadAsStringAsync();
                                        var status1 = pagina.StatusCode.ToString();
                                        float status;
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
                                        var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                        var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                    else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                    {



                                        string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                        //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                        ///////////////////////////////////////////
                                        //Console.WriteLine(arrayasignacionif[1].Length);
                                        var estoesarray = new Regex(".-_-.");
                                        /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                        {
                                            throw new Exception();
                                        }*/
                                        if (arrayasignacionif[1][0].ToString().Contains("a"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                a = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                b = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                c = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                d = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                e = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                f = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                g = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                h = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                i = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                j = arrayasignacionif[0];
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                k = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                l = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                m = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                n = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                ñ = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                o = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                p = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                q = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                r = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                s = float.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                        {
                                            var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                            {
                                                if (jajadivicion[zzz].Contains("NaN"))
                                                {
                                                    throw new Exception();
                                                }
                                                t[zzz] = float.Parse(jajadivicion[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                        {
                                            u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                        {
                                            var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                            {
                                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                w = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                x = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                y = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                        {
                                            if (estoesarray.IsMatch(arrayasignacionif[0]))
                                            {
                                                var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                z = bool.Parse(arrayasignacionif[0]);
                                            };
                                        }
                                        else
                                        {
                                            throw new Exception();
                                        };
                                    }
                                }
                            };
                        };
                    }
                    else if (laif.IsMatch(diviciondecodigo[xxx]))
                    {
                        var arrayasignacion = diviciondecodigo[xxx].Replace("¿!ª#", "\uFFFF").Split('\uFFFF');
                        /*string aa;
                        float ab;
                        bool ac;
                        string ba;
                        float bb;
                        bool bc;*/
                        string suno = null;
                        float funo = float.NaN;
                        string sdos = null;
                        float fdos = float.NaN;
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





                        //if (suno != null) { } else if (funo != float.NaN) { } else { };
                        if (suno == sdos)
                        {

                            var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                            for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                            {
                                if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                {
                                    var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                        var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                        //Console.WriteLine(variablus[1]);
                                        var consolear = t[int.Parse(numero[1].ToString())];
                                        Console.WriteLine(consolear);
                                    }
                                    else if (variablus[0].ToString().Contains("u"))
                                    {
                                        var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                        var consolear = u[int.Parse(numero[1].ToString())];
                                        Console.WriteLine(consolear);
                                    }
                                    else if (variablus[0].ToString().Contains("v"))
                                    {
                                        var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                {
                                    var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                {
                                    var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                    var conexion = new HttpClient();
                                    conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                    //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                    var pagina = await conexion.GetAsync(link);
                                    //pagina.EnsureSuccessStatusCode();
                                    var html = await pagina.Content.ReadAsStringAsync();
                                    var status1 = pagina.StatusCode.ToString();
                                    float status;
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
                                    var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                    var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                {



                                    string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                    //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                    ///////////////////////////////////////////
                                    //Console.WriteLine(arrayasignacionif[1].Length);
                                    var estoesarray = new Regex(".-_-.");
                                    /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                    {
                                        throw new Exception();
                                    }*/
                                    if (arrayasignacionif[1][0].ToString().Contains("a"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            a = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            b = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            c = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            d = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            e = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            f = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            g = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            h = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            i = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            j = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            k = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            l = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            m = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            n = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            ñ = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            o = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            p = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            q = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            r = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            s = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                    {
                                        var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                        {
                                            if (jajadivicion[zzz].Contains("NaN"))
                                            {
                                                throw new Exception();
                                            }
                                            t[zzz] = float.Parse(jajadivicion[zzz]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                    {
                                        u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                    {
                                        var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                        {
                                            v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            w = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            x = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            y = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            z = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    };
                                }
                            }
                        }
                        else if (funo == fdos)
                        {
                            var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                            for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                            {
                                if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                {
                                    var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                        var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                        //Console.WriteLine(variablus[1]);
                                        var consolear = t[int.Parse(numero[1].ToString())];
                                        Console.WriteLine(consolear);
                                    }
                                    else if (variablus[0].ToString().Contains("u"))
                                    {
                                        var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                        var consolear = u[int.Parse(numero[1].ToString())];
                                        Console.WriteLine(consolear);
                                    }
                                    else if (variablus[0].ToString().Contains("v"))
                                    {
                                        var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                {
                                    var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                {
                                    var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                    var conexion = new HttpClient();
                                    conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                    //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                    var pagina = await conexion.GetAsync(link);
                                    //pagina.EnsureSuccessStatusCode();
                                    var html = await pagina.Content.ReadAsStringAsync();
                                    var status1 = pagina.StatusCode.ToString();
                                    float status;
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
                                    var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                    var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                {



                                    string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                    //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                    ///////////////////////////////////////////
                                    //Console.WriteLine(arrayasignacionif[1].Length);
                                    var estoesarray = new Regex(".-_-.");
                                    /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                    {
                                        throw new Exception();
                                    }*/
                                    if (arrayasignacionif[1][0].ToString().Contains("a"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            a = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            b = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            c = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            d = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            e = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            f = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            g = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            h = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            i = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            j = arrayasignacionif[0];
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            k = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            l = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            m = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            n = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            ñ = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            o = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            p = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            q = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            r = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            s = float.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                    {
                                        var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                        {
                                            if (jajadivicion[zzz].Contains("NaN"))
                                            {
                                                throw new Exception();
                                            }
                                            t[zzz] = float.Parse(jajadivicion[zzz]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                    {
                                        u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                    {
                                        var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                        for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                        {
                                            v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            w = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            x = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            y = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                    {
                                        if (estoesarray.IsMatch(arrayasignacionif[0]))
                                        {
                                            var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                            //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                            z = bool.Parse(arrayasignacionif[0]);
                                        };
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    };
                                }
                            }
                        }
                        else
                        {
                            bool buno;
                            bool bdos;
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
                            else { };
                            //if(buno == true) { }else if(buno == false) { } else { };
                            if (buno == true)
                            {
                                if (buno == true)
                                {
                                    var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                    for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                    {
                                        if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                        {
                                            var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                                var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                                //Console.WriteLine(variablus[1]);
                                                var consolear = t[int.Parse(numero[1].ToString())];
                                                Console.WriteLine(consolear);
                                            }
                                            else if (variablus[0].ToString().Contains("u"))
                                            {
                                                var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                                var consolear = u[int.Parse(numero[1].ToString())];
                                                Console.WriteLine(consolear);
                                            }
                                            else if (variablus[0].ToString().Contains("v"))
                                            {
                                                var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                        else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                        {
                                            var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                        else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                        {
                                            var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                            var conexion = new HttpClient();
                                            conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                            //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                            var pagina = await conexion.GetAsync(link);
                                            //pagina.EnsureSuccessStatusCode();
                                            var html = await pagina.Content.ReadAsStringAsync();
                                            var status1 = pagina.StatusCode.ToString();
                                            float status;
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
                                            var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                            var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                        else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                        {



                                            string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                            //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                            ///////////////////////////////////////////
                                            //Console.WriteLine(arrayasignacionif[1].Length);
                                            var estoesarray = new Regex(".-_-.");
                                            /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                            {
                                                throw new Exception();
                                            }*/
                                            if (arrayasignacionif[1][0].ToString().Contains("a"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    a = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    b = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    c = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    d = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    e = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    f = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    g = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    h = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    i = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    j = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    k = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    l = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    m = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    n = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    ñ = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    o = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    p = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    q = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    r = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    s = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                            {
                                                var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                                for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                                {
                                                    if (jajadivicion[zzz].Contains("NaN"))
                                                    {
                                                        throw new Exception();
                                                    }
                                                    t[zzz] = float.Parse(jajadivicion[zzz]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                            {
                                                u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                            {
                                                var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                                for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                                {
                                                    v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    w = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    x = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    y = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    z = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else
                                            {
                                                throw new Exception();
                                            };
                                        }
                                    }
                                };
                            }
                            else if (buno == false)
                            {
                                if (buno == false)
                                {
                                    
                                    var nuevocodigo = diviciondecodigo[xxx].Substring("...¿!ª#".Length).Replace("◄►", "\uFFFF").Split('\uFFFF');
                                    for (var controladordenuevo = 0; controladordenuevo < nuevocodigo.Length; controladordenuevo++)
                                    {
                                        if (consola.IsMatch(nuevocodigo[controladordenuevo]))
                                        {
                                            var variablus = nuevocodigo[controladordenuevo].Replace("↓ùp👌", "");
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
                                                var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                                //Console.WriteLine(variablus[1]);
                                                var consolear = t[int.Parse(numero[1].ToString())];
                                                Console.WriteLine(consolear);
                                            }
                                            else if (variablus[0].ToString().Contains("u"))
                                            {
                                                var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                                                var consolear = u[int.Parse(numero[1].ToString())];
                                                Console.WriteLine(consolear);
                                            }
                                            else if (variablus[0].ToString().Contains("v"))
                                            {
                                                var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                        else if (archivus.IsMatch(nuevocodigo[controladordenuevo]))
                                        {
                                            var divicionenaccion = nuevocodigo[controladordenuevo].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                                        else if (http.IsMatch(nuevocodigo[controladordenuevo]))
                                        {
                                            var link = nuevocodigo[controladordenuevo].Split('¿')[1];
                                            var conexion = new HttpClient();
                                            conexion.DefaultRequestHeaders.Add("Authorization", nuevocodigo[controladordenuevo].Split('¿')[2].Substring(0, nuevocodigo[controladordenuevo].Split('¿')[2].Length - 1));
                                            //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                                            var pagina = await conexion.GetAsync(link);
                                            //pagina.EnsureSuccessStatusCode();
                                            var html = await pagina.Content.ReadAsStringAsync();
                                            var status1 = pagina.StatusCode.ToString();
                                            float status;
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
                                            var varparaelstatus = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[1];
                                            var varparalapagina = nuevocodigo[controladordenuevo].Split('¿')[0].Split('<')[0].Replace("l},º", "");
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
                                        else if (cambiarvalor.IsMatch(nuevocodigo[controladordenuevo]))
                                        {



                                            string[] arrayasignacionif = nuevocodigo[controladordenuevo].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
                                            //File.WriteAllText("C:\\Users\\Leandro-Arce\\ESCRITORIO\\lol.txt", arrayasignacionif[1]);

                                            ///////////////////////////////////////////
                                            //Console.WriteLine(arrayasignacionif[1].Length);
                                            var estoesarray = new Regex(".-_-.");
                                            /*if(arrayasignacionif[1].Length != 2 || arrayasignacionif[1].Length != 1)
                                            {
                                                throw new Exception();
                                            }*/
                                            if (arrayasignacionif[1][0].ToString().Contains("a"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    a = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("b"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    b = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("c"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    c = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("d"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    d = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("e"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    e = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("f"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    f = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("g"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    g = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("h"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    h = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("i"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    i = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("j"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    j = arrayasignacionif[0];
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("k")) ///los numeritos
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    k = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("l"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    l = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("m"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    m = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("n"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    n = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("ñ"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    ñ = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("o"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    o = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("p"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    p = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("q"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    q = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("r"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    r = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("s"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    s = float.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("t"))
                                            {
                                                var jajadivicion = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                                for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                                                {
                                                    if (jajadivicion[zzz].Contains("NaN"))
                                                    {
                                                        throw new Exception();
                                                    }
                                                    t[zzz] = float.Parse(jajadivicion[zzz]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("u"))
                                            {
                                                u = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("v"))
                                            {
                                                var jajadivicion2 = arrayasignacionif[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                                                for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                                                {
                                                    v[zzz] = bool.Parse(jajadivicion2[zzz]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("w"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    w = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("x"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    x = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("y"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    y = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else if (arrayasignacionif[1][0].ToString().Contains("z"))
                                            {
                                                if (estoesarray.IsMatch(arrayasignacionif[0]))
                                                {
                                                    var divicionSuprema = arrayasignacionif[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                                    //if (arrayasignacionif[0] == "NaN") throw new Exception();
                                                    z = bool.Parse(arrayasignacionif[0]);
                                                };
                                            }
                                            else
                                            {
                                                throw new Exception();
                                            };
                                        }
                                    }
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
                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                            //Console.WriteLine(variablus[1]);
                            var consolear = t[int.Parse(numero[1].ToString())];
                            Console.WriteLine(consolear);
                        }
                        else if (variablus[0].ToString().Contains("u"))
                        {
                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
                            var consolear = u[int.Parse(numero[1].ToString())];
                            Console.WriteLine(consolear);
                        }
                        else if (variablus[0].ToString().Contains("v"))
                        {
                            var numero = variablus.Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                        var divicionenaccion = diviciondecodigo[xxx].Replace("csis", "\uFFFF").Split('\uFFFF');
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
                        var conexion = new HttpClient();
                        conexion.DefaultRequestHeaders.Add("Authorization", diviciondecodigo[xxx].Split('¿')[2].Substring(0, diviciondecodigo[xxx].Split('¿')[2].Length - 1));
                        //conexion.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                        var pagina = await conexion.GetAsync(link);
                        //pagina.EnsureSuccessStatusCode();
                        var html = await pagina.Content.ReadAsStringAsync();
                        var status1 = pagina.StatusCode.ToString();
                        float status;
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



                        string[] arrayasignacion = diviciondecodigo[xxx].Replace("¨ç]", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                k = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("l"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                l = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("m"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                m = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("n"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                n = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("ñ"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                ñ = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("o"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                o = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("p"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                p = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("q"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                q = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("r"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                r = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("s"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                s = float.Parse(arrayasignacion[0]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("t"))
                        {
                            var jajadivicion = arrayasignacion[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                            for (var zzz = 0; zzz < jajadivicion.Length; zzz++)
                            {
                                if (jajadivicion[zzz].Contains("NaN"))
                                {
                                    throw new Exception();
                                }
                                t[zzz] = float.Parse(jajadivicion[zzz]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("u"))
                        {
                            u = arrayasignacion[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("v"))
                        {
                            var jajadivicion2 = arrayasignacion[0].Replace("º-/*", "\uFFFF").Split('\uFFFF');
                            for (var zzz = 0; zzz < jajadivicion2.Length; zzz++)
                            {
                                v[zzz] = bool.Parse(jajadivicion2[zzz]);
                            };
                        }
                        else if (arrayasignacion[1][0].ToString().Contains("w"))
                        {
                            if (estoesarray.IsMatch(arrayasignacion[0]))
                            {
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                                var divicionSuprema = arrayasignacion[0].Replace("-_-", "\uFFFF").Split('\uFFFF');
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
                    else
                    {
                        throw new Exception();
                    };
                };

                while (true) { };

            }
            catch (Exception x)
            {
                Console.Title = "Troll Script";
                //Console.Clear();
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
            Console.Title = "Troll Script";
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
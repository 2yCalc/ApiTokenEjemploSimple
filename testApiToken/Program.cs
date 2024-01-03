// See https://aka.ms/new-console-template for more information
using testApiToken;


// si este codigo lo hacemos en un end point que valide usuarios y pwd nos devuelve el token generado 
// y este token usarlo en otras llamadas



Console.WriteLine("Token Generado Automaticamente");

var a = new GeneradorToken("JL9s0KrpZtR2Q3cG7vXwEh5iNUYlTyDnCI8OqzoAPjF1x6e4gmbWauHdSfVk");

var b = a.GenerarTokenJWT();

Console.WriteLine(b);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.util
{
    class CyberSec
    {
        /*
         * Habemos un par de compañeros aficionados a la cyber seguridad en nuestro equipo
         * Previo a trabajar los registros de usuarios en nuestra aplicacion 
         * he tomado la humilde decision de crear esta clase adelantandome a la expectativa
         * de mi compañero a que guarde los pw en texto plano como hacen Fb y Twitter
         */
        public static string HolaCosmos(string pw)
        {            
            return Encrypt(pw);
        }

        private static string Encrypt (string textoplano)
        {
            hash = "PRN115 2024 gr6 eq2"; //hash unico programacion I 2024 grupo teorico 6 equipo 2
            byte[] data = UTF8Encoding.UTF8.GetBytes(textoplano);

            MD5 md5 = MD5.Create(); //clase del paquete seguridad > criptografia
            TripleDES tripldes = TripleDES.Create();

            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripldes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripldes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            //Debo asegurarme que el resultado no sea mayor a 60 caractares por la restriccion VARCHAR de la base de datos cg2bd

            return Convert.ToBase64String(result);
        }

        private static string Decrypt(string textoEnc)
        {
            hash = "PRN115 2024 gr6 eq2"; //hash unico programacion I 2024 grupo teorico 6 equipo 2
            byte[] data = Convert.FromBase64String(textoEnc);

            MD5 md5 = MD5.Create(); //clase del paquete seguridad > criptografia
            TripleDES tripldes = TripleDES.Create();

            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripldes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripldes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            //Debo asegurarme que el resultado no sea mayor a 60 caractares por la restriccion VARCHAR de la base de datos cg2bd

            return UTF8Encoding.UTF8.GetString(result);
        }

        public static string Saracay(string saracay)
        {
            return Decrypt(saracay);
        }

        private static string hash;
    }
}

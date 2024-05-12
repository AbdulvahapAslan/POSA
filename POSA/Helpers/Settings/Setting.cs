using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POSA.Helpers.Settings;
public class Setting
{
    public static SettingType Get()
    {
        try
        {
            if (!File.Exists(Yol))
                Kaydet(new SettingType());
            lock (LockObj)
            {
                var jsn = File.ReadAllText(Yol, Encoding.UTF8).ReverseString().Base64Decrypt();
                return JsonConvert.DeserializeObject<SettingType>(jsn);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public static bool Kaydet(SettingType a)
    {
        try
        {
            lock (LockObj)
            {
                var jsn = JsonConvert.SerializeObject(a).Base64Decrypt().ReverseString();
                File.WriteAllText(Yol, jsn, Encoding.UTF8);
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    private static readonly string Yol = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ayar.avp");
    private static object LockObj = new object();
}

using MessagePack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

[MessagePackObject]
public class MSP_Game_Base
{
    [Key(0)] public int Var_int;
    [Key(1)] public float Var_float;
    [Key(2)] public string Var_string;
    [Key(3)] public List<int> Var_list_int;
    [Key(4)] public List<float> Var_list_float;
    [Key(5)] public List<string> Var_list_string;

    public MSP_Game_Base() { }
    public MSP_Game_Base(Dictionary<string, object> Data)
    {
        Var_int = Convert.ToInt32(Data["Var_int"]);
        Var_float = Convert.ToSingle(Data["Var_float"]);
        Var_string = Convert.ToString(Data["Var_string"]);

        Var_list_int = JsonConvert.DeserializeObject<List<int>>(Convert.ToString(Data["Var_list_int"]));
        Var_list_float = JsonConvert.DeserializeObject<List<float>>(Convert.ToString(Data["Var_list_float"])); 
        Var_list_string = JsonConvert.DeserializeObject<List<string>>(Convert.ToString(Data["Var_list_string"])); 
        
    }

}
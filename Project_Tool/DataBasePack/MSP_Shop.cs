using MessagePack;
using System;
using System.Collections.Generic;

[MessagePackObject]
public class MSP_Shop
{
    [Key(0)] public string Goods;
    [Key(1)] public int GoodsAmount;
    [Key(2)] public string Icon;
    [Key(3)] public string Description;

    public MSP_Shop() { }

    public MSP_Shop(Dictionary<string, object> Data)
    {
        Goods = Convert.ToString(Data["Goods"]);
        GoodsAmount = Convert.ToInt32(Data["GoodsAmount"]);
        Icon = Convert.ToString(Data["Icon"]);
        Description = Convert.ToString(Data["Description"]);
    }

}
﻿public class HF  {
    public string description;
    public int nb;
    public TYPE_HF type;
    public int gold;

    public enum TYPE_HF { Kill, Bonus };

    public HF(TYPE_HF type, string description, int nb, int gold)
    {
        this.description = description;
        this.nb = nb;
        this.type = type;
        this.gold = gold;
    }
}

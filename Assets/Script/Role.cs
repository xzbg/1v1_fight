using System;
using System.Collections.Generic;

[Serializable]
public class Role
{
    public int id;
    public string name;
    public int state;
    public int attack;
    public int defense;
    public int hp;
    public int speed;

    public List<Skill> skills = new List<Skill>();
}

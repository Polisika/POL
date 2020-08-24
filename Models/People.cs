using System;

namespace Models
{
    public class People
    {
        public People(string[] row)
        {
            sys_name = row[0];
            name = row[1];
            type = row[2];
            health = row[3];
            strength = row[4];
            dexterity = row[5];
            reaction = row[6];
            accuracy = row[7];
            morale = row[8];
            wisdom = row[9];
            mechanics = row[10];
            sight_radius = row[11];
            sight_angle = row[12];
            experience = row[13];
            flame_res = row[14];
            electric_res = row[15];
            shock_res = row[16];
            base_levelup = row[17];
            levelup_rise = row[18];
            fibre = row[19];
            force = row[20];
            description = row[21];
            animations = row[22];
            skin = row[23];
            Suit1 = row[24];
            Suit2 = row[25];
            Suit3 = row[26];
            Suit4 = row[27];
            Scuba = row[28];
            danger_points = row[29];
            shot_bone = row[30];
            view_bone = row[31];
            rank = row[32];
            cannot_dismiss = row[33];
            can_swap = row[34];
            can_use_scuba = row[35];
        }
        public string sys_name { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string health { get; set; }
        public string strength { get; set; }
        public string dexterity { get; set; }
        public string reaction { get; set; }
        public string accuracy { get; set; }
        public string morale { get; set; }
        public string wisdom { get; set; }
        public string mechanics { get; set; }
        public string sight_radius { get; set; }
        public string sight_angle { get; set; }
        public string experience { get; set; }
        public string flame_res { get; set; }
        public string electric_res { get; set; }
        public string shock_res { get; set; }
        public string base_levelup { get; set; }
        public string levelup_rise { get; set; }
        public string fibre { get; set; }
        public string force { get; set; }
        public string description { get; set; }
        public string animations { get; set; }
        public string skin { get; set; }
        public string Suit1 { get; set; }
        public string Suit2 { get; set; }
        public string Suit3 { get; set; }
        public string Suit4 { get; set; }
        public string Scuba { get; set; }
        public string danger_points { get; set; }
        public string shot_bone { get; set; }
        public string view_bone { get; set; }
        public string rank { get; set; }
        public string cannot_dismiss { get; set; }
        public string can_swap { get; set; }
        public string can_use_scuba { get; set; }

        public override string ToString()
        {
            return sys_name + "\t" + name + "\t" + type + "\t" + health + "\t" + strength + "\t" + dexterity + "\t" + reaction + "\t" + accuracy + "\t" + morale + "\t" + wisdom + "\t" + mechanics + "\t" + sight_radius + "\t" + sight_angle + "\t" + experience + "\t" + flame_res + "\t" + electric_res + "\t" + shock_res + "\t" + base_levelup + "\t" + levelup_rise + "\t" + fibre + "\t" + force + "\t" + description + "\t" + animations + "\t" + skin + "\t" + Suit1 + "\t" + Suit2 + "\t" + Suit3 + "\t" + Suit4 + "\t" + Scuba + "\t" + danger_points + "\t" + shot_bone + "\t" + view_bone + "\t" + rank + "\t" + cannot_dismiss + "\t" + can_swap + "\t" + can_use_scuba;
        }
    }
}

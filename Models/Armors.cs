using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Armors
    {
        public Armors(string[] row)
        {
            sys_name = row[0];
            name = row[1];
            initials = row[2];
            type = row[3];
            strength = row[4];
            slots = row[5];
            weight = row[6];
            body = row[7];
            legs = row[8];
            hands = row[9];
            head = row[10];
            rear_amplify = row[11];
            mp_to_activate = row[12];
            item_model = row[13];
            item_shader = row[14];
            item_width = row[15];
            item_height = row[16];
            suit = row[17];
            file_name = row[18];
            game_visuals = row[19];
            basic_cost = row[20];
            description = row[21];
            min_rank = row[22];
        }
        public string sys_name { get; set; }
        public string name { get; set; }
        public string initials { get; set; }
        public string type { get; set; }
        public string strength { get; set; }
        public string slots { get; set; }
        public string weight { get; set; }
        public string body { get; set; }
        public string legs { get; set; }
        public string hands { get; set; }
        public string head { get; set; }
        public string rear_amplify { get; set; }
        public string mp_to_activate { get; set; }
        public string item_model { get; set; }
        public string item_shader { get; set; }
        public string item_width { get; set; }
        public string item_height { get; set; }
        public string suit { get; set; }
        public string file_name { get; set; }
        public string game_visuals { get; set; }
        public string basic_cost { get; set; }
        public string description { get; set; }
        public string min_rank { get; set; }

        public override string ToString()
        {
            return sys_name + "\t" + name + "\t" + initials + "\t" + type + "\t" + strength + "\t" + slots + "\t" + weight + "\t" + body + "\t" + legs + "\t" + hands + "\t" + head + "\t" + rear_amplify + "\t" + mp_to_activate + "\t" + item_model + "\t" + item_shader + "\t" + item_width + "\t" + item_height + "\t" + suit + "\t" + file_name + "\t" + game_visuals + "\t" + basic_cost + "\t" + description + "\t" + min_rank;
        }
    }
}

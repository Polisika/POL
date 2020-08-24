namespace Models
{
    public class Weapons
    {
        public Weapons(string[] row)
        {
            sys_name = row[0];
            name = row[1];
            initials = row[2];
            basic_cost = row[3];
            hold_type = row[4];
            strength = row[5];
            wisdom = row[6];
            caliber = row[7];
            weight = row[8];
            qty_in_aim_shot = row[9];
            qty_in_auto_shot = row[10];
            mp_to_shot = row[11];
            mp2reload = row[12];
            basic_damage = row[13];
            additional_damage = row[14];
            basic_damage_type = row[15];
            additional_damage_type = row[16];
            range = row[17];
            basic_quality = row[18];
            basic_accuracy = row[19];
            shot_sound = row[20];
            autoshot_sound = row[21];
            ammo_load_sound = row[22];
            hold_model = row[23];
            flash_effect_name = row[24];
            item_model = row[25];
            item_shader = row[26];
            item_width = row[27];
            item_height = row[28];
            barrel = row[29];
            shell = row[30];
            description = row[31];
            min_rank = row[32];
            max_scatter = row[33];
        }
        public string sys_name { get; set; }
        public string name { get; set; }
        public string initials { get; set; }
        public string basic_cost { get; set; }
        public string hold_type { get; set; }
        public string strength { get; set; }
        public string wisdom { get; set; }
        public string caliber { get; set; }
        public string weight { get; set; }
        public string qty_in_aim_shot { get; set; }
        public string qty_in_auto_shot { get; set; }
        public string mp_to_shot { get; set; }
        public string mp2reload { get; set; }
        public string basic_damage { get; set; }
        public string additional_damage { get; set; }
        public string basic_damage_type { get; set; }
        public string additional_damage_type { get; set; }
        public string range { get; set; }
        public string basic_quality { get; set; }
        public string basic_accuracy { get; set; }
        public string shot_sound { get; set; }
        public string autoshot_sound { get; set; }
        public string ammo_load_sound { get; set; }
        public string hold_model { get; set; }
        public string flash_effect_name { get; set; }
        public string item_model { get; set; }
        public string item_shader { get; set; }
        public string item_width { get; set; }
        public string item_height { get; set; }
        public string barrel { get; set; }
        public string shell { get; set; }
        public string description { get; set; }
        public string min_rank { get; set; }
        public string max_scatter { get; set; }

        public override string ToString()
        {
            return sys_name + "\t" + name + "\t" + initials + "\t" + basic_cost + "\t" + hold_type + "\t" + strength + "\t" + wisdom + "\t" + caliber + "\t" + weight + "\t" + qty_in_aim_shot + "\t" + qty_in_auto_shot + "\t" + mp_to_shot + "\t" + mp2reload + "\t" + basic_damage + "\t" + additional_damage + "\t" + basic_damage_type + "\t" + additional_damage_type + "\t" + range + "\t" + basic_quality + "\t" + basic_accuracy + "\t" + shot_sound + "\t" + autoshot_sound + "\t" + ammo_load_sound + "\t" + hold_model + "\t" + flash_effect_name + "\t" + item_model + "\t" + item_shader + "\t" + item_width + "\t" + item_height + "\t" + barrel + "\t" + shell + "\t" + description + "\t" + min_rank + "\t" + max_scatter;
        }
    }
}

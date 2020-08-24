using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Tech
    {
        public Tech(string[] row)
        {
            sys_name = row[0];
            name = row[1];
            size = row[2];
            type = row[3];
            movepoints = row[4];
            basic_damage = row[5];
            additional_damage = row[6];
            death_damage = row[7];
            death_radius = row[8];
            death_effect = row[9];
            range = row[10];
            radius = row[11];
            accuracy = row[12];
            shots = row[13];
            quality = row[14];
            mp_shot = row[15];
            shells_effect = row[16];
            fall_off = row[17];
            weapon_icon = row[18];
            ammo_info = row[19];
            skin = row[20];
            flash_effect = row[21];
            trace_effect = row[22];
            hit_effect = row[23];
            shell = row[24];
            capacity = row[25];
            dexterity = row[26];
            reaction = row[27];
            sight_radius = row[28];
            sight_angle = row[29];
            drive = row[30];
            intelligence = row[31];
            armor = row[32];
            health = row[33];
            expirience_for_kill = row[34];
            expirience_for_hack = row[35];
            shot_sound = row[36];
            move_sound = row[37];
            lazy_sound = row[38];
            damage_sound = row[39];
            explode_sound = row[40];
            engine_sound = row[41];
            description = row[42];
            danger_points = row[43];
            shot_bone = row[44];
            view_bone = row[45];
        }
        public string sys_name { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string movepoints { get; set; }
        public string basic_damage { get; set; }
        public string additional_damage { get; set; }
        public string death_damage { get; set; }
        public string death_radius { get; set; }
        public string death_effect { get; set; }
        public string range { get; set; }
        public string radius { get; set; }
        public string accuracy { get; set; }
        public string shots { get; set; }
        public string quality { get; set; }
        public string mp_shot { get; set; }
        public string shells_effect { get; set; }
        public string fall_off { get; set; }
        public string weapon_icon { get; set; }
        public string ammo_info { get; set; }
        public string skin { get; set; }
        public string flash_effect { get; set; }
        public string trace_effect { get; set; }
        public string hit_effect { get; set; }
        public string shell { get; set; }
        public string capacity { get; set; }
        public string dexterity { get; set; }
        public string reaction { get; set; }
        public string sight_radius { get; set; }
        public string sight_angle { get; set; }
        public string drive { get; set; }
        public string intelligence { get; set; }
        public string armor { get; set; }
        public string health { get; set; }
        public string expirience_for_kill { get; set; }
        public string expirience_for_hack { get; set; }
        public string shot_sound { get; set; }
        public string move_sound { get; set; }
        public string lazy_sound { get; set; }
        public string damage_sound { get; set; }
        public string explode_sound { get; set; }
        public string engine_sound { get; set; }
        public string description { get; set; }
        public string danger_points { get; set; }
        public string shot_bone { get; set; }
        public string view_bone { get; set; }

        public override string ToString() 
        { 
            return sys_name + "\t" + name + "\t" + size + "\t" + type + "\t" + movepoints + "\t" + basic_damage + "\t" + additional_damage + "\t" + death_damage + "\t" + death_radius + "\t" + death_effect + "\t" + range + "\t" + radius + "\t" + accuracy + "\t" + shots + "\t" + quality + "\t" + mp_shot + "\t" + shells_effect + "\t" + fall_off + "\t" + weapon_icon + "\t" + ammo_info + "\t" + skin + "\t" + flash_effect + "\t" + trace_effect + "\t" + hit_effect + "\t" + shell + "\t" + capacity + "\t" + dexterity + "\t" + reaction + "\t" + sight_radius + "\t" + sight_angle + "\t" + drive + "\t" + intelligence + "\t" + armor + "\t" + health + "\t" + expirience_for_kill + "\t" + expirience_for_hack + "\t" + shot_sound + "\t" + move_sound + "\t" + lazy_sound + "\t" + damage_sound + "\t" + explode_sound + "\t" + engine_sound + "\t" + description + "\t" + danger_points + "\t" + shot_bone + "\t" + view_bone;
        }
    }
}

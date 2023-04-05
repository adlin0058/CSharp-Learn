using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_JSON操作
{
    internal class Hero
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxHp { get; set; }
        public List<Skill> SkillList { get; set; }
    }
}
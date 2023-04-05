using Newtonsoft.Json;

namespace _37_JSON操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //                          反序列化JSON->类
            //var skills = JsonConvert.DeserializeObject<Skill[]>(File.ReadAllText("Skills.json"));
            //foreach (Skill s in skills)
            //{
            //    Console.WriteLine(s.Id + "," + s.Name + "," + s.Damage);
            //}

            //Skill skill = new Skill();
            //skill.Id = 007;
            //skill.Name = "MiKu";
            //skill.Damage = 9999;
            //string str = JsonConvert.SerializeObject(skill);
            //Console.WriteLine(str);

            Hero hero = JsonConvert.DeserializeObject<Hero>(File.ReadAllText("Heros.json"));
            Console.WriteLine(hero.Name);
            Console.WriteLine(hero.Type);
            Console.WriteLine(hero.MaxHp);
            foreach (Skill s in hero.SkillList)
            {
                Console.WriteLine(s.Id + "," + s.Name + "," + s.Damage);
            }
        }
    }
}
using System.Xml;

namespace _36_XML操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //XmlDocument对象
            XmlDocument xmlDoc = new XmlDocument();
            //对象加载XML文件
            xmlDoc.Load("Skills.xml");
            //获得根节点
            XmlNode root = xmlDoc.ChildNodes[1];
            //把根节点的子节点放入列表中
            XmlNodeList skillList = root.ChildNodes;
            //遍历
            //遍历节点列表中的节点
            foreach (XmlNode skillNode in skillList)
            {
                //遍历节点中的子节点
                foreach (XmlNode node in skillNode.ChildNodes)
                {
                    Console.WriteLine(node.Name + ":" + node.InnerText);
                }
            }
        }
    }
}
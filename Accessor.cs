using System.Resources;

namespace Kesco.Lib.Localization
{
    /// <summary>
    /// Класс содержащий статический объект менеджер ресурсов
    /// </summary>
    public class Resources
    {
        /// <summary>
        /// Статический менеджер ресурсов
        /// </summary>
        public static ResourceManager Resx
        {
            get { return new ResourceManager(typeof (ResContainer)); }
        }
    }
}
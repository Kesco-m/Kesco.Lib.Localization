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

        /// <summary>
        /// Статический менеджер ресурсов Accounting
        /// </summary>
        public static ResourceManager ResxAccounting
        {
            get { return new ResourceManager(typeof(Accounting.ResContainer)); }
        }

        /// <summary>
        /// Статический менеджер ресурсов документа Указаний ИТ
        /// </summary>
        public static ResourceManager ResxDocsDirection
        {
            get { return new ResourceManager(typeof(Docs.Directions.ResContainer)); }
        }

        /// <summary>
        /// Статический менеджер ресурсов Инвентаризации
        /// </summary>
        public static ResourceManager ResxCorporate
        {
            get { return new ResourceManager(typeof(Corporate.ResContainer)); }
        }

        /// <summary>
        /// Статический менеджер ресурсов Звонилка
        /// </summary>
        public static ResourceManager ResxDialing
        {
            get { return new ResourceManager(typeof(Dialing.ResContainer)); }
        }

        /// <summary>
        /// Статический менеджер ресурсов Территории
        /// </summary>
        public static ResourceManager ResxArea
        {
            get { return new ResourceManager(typeof(Corporate.Areas.ResContainer )); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// Mon Singleton
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;

        /// <summary>
        /// Constructeur privé qui protège l'instanciation de cette classe
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// Attention, cette écriture est dire "non thread-safe" car elle ne protège pas d'une instanciation par 2 threads en simultané
        /// </summary>
        public static Singleton NonThreadSafeInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        /// <summary>
        /// Obtention du singleton qui est "thread safe" c-à-d protégé des instanciations par 
        /// 2 threads concurrents
        /// </summary>
        public static Singleton ThreadSafeInstance
        {
            get
            {
                return SingletonWrapper.Instance;
            }
        }

        private static class SingletonWrapper
        {
            private static Singleton instance = new Singleton();

            /// <summary>
            /// Obtient l'instance du singleton
            /// </summary>
            public static Singleton Instance { get { return instance; } }
        }
    }
}

using System;

namespace Events
{
    class Program
    {
        internal Product Product
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        ///     Аргументы события изменения имени.
        /// </summary>
        class NameChangeEventArgs : EventArgs
        {
            /// <summary>
            ///     Имя до события.
            /// </summary>
            public string Old { get; }
            
            /// <summary>
            ///     Имя, после события.
            /// </summary>
            public string Current { get; }

            public NameChangeEventArgs(string old, string current)
            {
                Old = old;
                Current = current;
            }
        }
        
        /// <summary>
        ///     Представление о человеке
        /// </summary>
        class Person
        {
            /// <summary>
            ///     Переменная, для хранения имени человека
            /// </summary>
            private string _name;
            /// <summary>
            ///     Свойство, обеспечивающее доступ к инкапсулированому имени.
            /// </summary>
            public string Name
            {
                get { return _name; }
                set
                {
                    var args = new NameChangeEventArgs(_name, value);
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, args);
                    }
                }
            }
            /// <summary>
            ///     Событие, сигнализирубщее о том, что имя человека было изменено.
            /// </summary>
            public event EventHandler<NameChangeEventArgs> NameChanged;
           
            // ...
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.NameChanged += OnPersonNameChanged;
            Product product = new Product("Some product name", 0);
            
            /* 
             * TODO #6 Назначить обработчики событий в текущем контексте 
             */

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }

        /// <summary>
        ///     Обработчик события изменения имени человека
        /// </summary>
        private static void OnPersonNameChanged(object sender, NameChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void OnHandleEvent(object sender, EventArgs e)
        {
            
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

    }
}

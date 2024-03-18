using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase
{
    internal class FirebaseManager
    {
        private static FirebaseManager instance;
        private readonly IFirebaseClient client;


        private FirebaseManager() {

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "XojNTECJu7yRQN7srDaH1M9J7eJMGQshFHQxuGnU",
                BasePath = "https://apartmentcare-ab691-default-rtdb.europe-west1.firebasedatabase.app/"
            };
            client = new FireSharp.FirebaseClient(config);
        }

        public static FirebaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FirebaseManager();
                }

                return instance;
            }
        }

        public IFirebaseClient Client { get { return client; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace spt_0._1
{
    [FirestoreData]
    public class FirebaseProperty
    {
        [FirestoreProperty]
        //필드 이름
        public string Password { get; set; }
        [FirestoreProperty]
        public string Folder { get; set; }
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Platform { get; set; }


    }
}

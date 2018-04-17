using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doosanTransChatBot.Models
{
    [Serializable]
    public class RelationList
    {
        public string luisId;
        public string luisIntent;
        public string luisEntities;
        public int dlgId;
        public int dlgOrderNo;
        public string dlgApiDefine;
        public int apiId;
        public int luisScore;
    }
}
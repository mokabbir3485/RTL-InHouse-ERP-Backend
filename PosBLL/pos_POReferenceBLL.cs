﻿using System;
using PosDAL;
using PosEntity;
using System.Collections.Generic;

namespace PosBLL
{
    public class pos_POReferenceBLL
    {
        public pos_POReferenceDAO pos_POReferenceDAO { get; set; }

        public pos_POReferenceBLL()
        {
            pos_POReferenceDAO = new pos_POReferenceDAO();
        }


        public List<pos_POReference> GetPOReference(string DocType, Int64 DocumentId)
        {
            try
            {
                return pos_POReferenceDAO.GetPOReference(DocType, DocumentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(pos_POReference _pos_POReference)
        {
            try
            {
                return pos_POReferenceDAO.Add(_pos_POReference);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

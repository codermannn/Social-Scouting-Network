﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void DeleteComment(Comment comment);
        //void UpdateComment(Comment comment);
        List<Comment> GetListWithAllAttribution();
        List<Comment> GetList(int id);
        //Comment GetByID(int id);
        //List<Comment> GetListWithAllAttribution();
    }
}

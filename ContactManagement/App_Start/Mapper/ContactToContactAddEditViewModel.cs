﻿using AutoMapper;
using ContactManagement.Models;
using ContactManagement.ViewModel;

namespace ContactManagement.Mapper
{
    public class ContactToContactAddEditViewModel:Profile
    {
        protected override void Configure()
        {
            base.Configure();
            AutoMapper.Mapper.CreateMap<Contact, ContactAddEditViewModel>();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        // TODO: Add your service operations here

        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomers, string NoTelepon, int JumlahPemesanan, string IDLokasi);//method//proses input data
        [OperationContract]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon);
        [OperationContract]
        string deletePemesann(string IDPemesanan);
        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //menampilkan  data yang ada di database(select all) //menampilkan isi dari yang ada contact
        [OperationContract]
        List<DetailLokasi> DetailLokasi(); //menampilkan detail lokasi
        [OperationContract]
        List<Pemesanan> Pemesanan();

        [OperationContract]
        string Login(string username, string password);

        [OperationContract]
        string Register(string username, string password, string kategori);

        [OperationContract]
        string UpdateRegister(string username, string password, string kategori, int id);

        [OperationContract]
        string DeleteRegister(string username);

        [OperationContract]
        List<DataRegister> DataRegist();
    }

    [DataContract]
    public class DataRegister
    {
        [DataMember(Order = 1)]
        public int id { get; set; }
        [DataMember(Order = 2)]
        public string username { get; set; }
        [DataMember(Order = 3)]
        public string password { get; set; }
        [DataMember(Order = 4)]
        public string kategori { get; set; }
    }

        [DataContract]
    public class CekLokasi //daftar lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; }// variable dari public klass
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }

    [DataContract]
    public class DetailLokasi //menampilkan detail lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; }// variable dari public klass
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiFull { get; set; }
        [DataMember]
        public int Kouta { get; set; }
    }

    [DataContract]
    public class Pemesanan 
    {
        [DataMember]
        public string IDPemesanan { get; set; }// variable dari public klass
        [DataMember]
        public string NamaCustomer { get; set; }
        [DataMember]
        public string NoTelepon { get; set; }
        [DataMember]
        public int JumlahPemesanan { get; set; }
        [DataMember]
        public string Lokasi { get; set; }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceReservasi.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

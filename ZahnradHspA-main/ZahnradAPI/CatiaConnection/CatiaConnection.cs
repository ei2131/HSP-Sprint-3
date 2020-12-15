using System;
using System.Windows;
using INFITF;
using MECMOD;
using PARTITF;


namespace Zahnrad
{
    class CatiaConnection
    {
        INFITF.Application hsp_catiaApp;
        MECMOD.PartDocument hsp_catiaPart;
        MECMOD.Sketch hsp_catiaProfil;

        public bool CATIALaeuft()
        {
            try
            {
                object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                hsp_catiaApp = (Application)catiaObject;
                return true;
            }
            catch (Exception)
            {
                return false;
            }        
        }



    }
}

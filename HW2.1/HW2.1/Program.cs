using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'M';//to string
            string sex1 = Convert.ToString(sex); //"M", convert

            //char place = '3';//to int
            //int iPlace = Convert.ToInt(place);
            //char hasFingerPrints = '0'; //to boolean
            //bool bHasFingerPrints = Convert.ToBoolean(hasFingerPrints)

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoBool = Convert.ToBoolean(hasPhotoString);//"True", convert

            string flatNumber = "34";//to int
            int flatNumInt = Convert.ToInt32(flatNumber);//"34", convert

            string visaPriceString = "34,23";//to float
            float visaPriceFloat = Convert.ToSingle(visaPriceString);//"34,23", convert

            //string photoPriceString = "7.23";//to float

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string sFree2Pages = Convert.ToString(hasFree2Pages);//"False", convert

            //char cFree2Pages = Convert.ToChar(hasFree2Pages);

            int iFree2Pages = Convert.ToInt32(hasFree2Pages);//"0", convert

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            int iVisaPrice = Convert.ToInt32(visaPrice);//"60", convert

            string sVisaPrice = Convert.ToString(visaPrice);//"60", convert


            double fingerPrintsPrice = 55.2;//to int, to string. typo: in "finterPrintsPrice" :)
            int iFingerPrintsPrice = Convert.ToInt32(fingerPrintsPrice);//"55", convert

            string sFingerPrintsPrice = Convert.ToString(fingerPrintsPrice);//"55.2", convert

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            string sBirthYear = Convert.ToString(birthYear);//"2000", convert

            double dBirthYear = birthYear;//"2000", convert

            char birthYearChar = Convert.ToChar(birthYear);//"?" - explicit, "?" - convert

            int hasPhotoInt = 1;//to boolean
            bool bHasPhoto = Convert.ToBoolean(hasPhotoInt);//"True", convert
        }
    }
}

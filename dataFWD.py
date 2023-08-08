# -*- coding: utf-8 -*-
"""
Created on Mon Aug  7 09:35:55 2023

@author: ingeniero01
"""
import math

archivo = open("ovalo.fwd", "r", encoding=("utf-16"))
nuevo = open("ovala.fwd", "w")

for h in archivo:

    if "Carga   " in h:
        h = h.replace("Carga", "Carga   Drop")
    if "kN   " in h:
        h = h.replace("kN", "kN   mts.")
    if "----" in h:
        h = h.replace(" --- --------", " --- -------- ------")
    if h[0] == "D":
        if float(h.split()[3]) > 50:
            h = h.replace(h.split()[3], h.split()[3]+"    150")
        elif float(h.split()[3]) > 40:
            h = h.replace(h.split()[3], h.split()[3]+"    140")
        elif float(h.split()[3]) > 28:
            h = h.replace(h.split()[3], h.split()[3]+"    130")
    nuevo.write(h)
    j = h.split()
    if h[0] == "D":
        lat = j[-3:-2]
        lat1 = int(lat[0][:3])
        lat2 = float(lat[0][3:])
        latmin = int(math.modf(lat2)[1])
        latseg = math.modf(lat2)[0]*60
        print(lat, lat1,  latmin, round(math.modf(lat2)[0],3), "{0:.5f}".format(latseg) )
        
        if lat1 > 0:
            lati = round(lat1 + (lat2/60),5)
        else:
            lati = round(lat1 - (lat2/60),5)
        
        long = j[-2:-1]
        long1 = int(long[0][:4])
        long2 = float(long[0][4:])
        if long1 > 0:
            longi= round(long1 + (long2/60),5)
        else:
            longi = round(long1 - (long2/60),5)
        j.append(lati)
        j.append(longi)
        #print(j[18:])
    
   # print(j)

    


nuevo.close()
archivo.close()
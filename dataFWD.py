# -*- coding: utf-8 -*-
"""
Created on Mon Aug  7 09:35:55 2023

@author: ingeniero01
"""
import binascii

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
        print(h)
        if float(h.split()[3]) > 50:
            h = h.replace(h.split()[3], h.split()[3]+"    150")
        elif float(h.split()[3]) > 40:
            h = h.replace(h.split()[3], h.split()[3]+"    140")
        elif float(h.split()[3]) > 28:
            h = h.replace(h.split()[3], h.split()[3]+"    130")
    nuevo.write(h)




nuevo.close()
archivo.close()
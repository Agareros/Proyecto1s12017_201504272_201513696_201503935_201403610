class Usuario:
    def __init__(self, usuario, contra, nombre):
        self.usuario = usuario
        self.contra = contra
        self.nombre = nombre


class NodoMatriz:

    def __init__(self):
        self.emp = None
        self.dep = None
        self.per = None
        self.arr = None
        self.aba = None
        self.ant = None
        self.sig = None
        self.ad = None
        self.atr = None


class Dispersa:

    bandera = False
    puntero = NodoMatriz()
    raiz = NodoMatriz()

    def __init__(self):
        self.raiz.emp = "Origen"
        self.raiz.dep = "Origen"


    def vacia(self):
        if self.raiz.sig == None or self.raiz.aba == None:
            return True
        else:
            return False
    
    def contar_col(self, puntero):
        temp = puntero
        num = -1
        while temp != None:
            temp = temp.aba
            num = num+1
        return temp

    def contar_fil(self, puntero):
        temp = puntero
        num = -0
        while  temp != None:
            if temp.sig != None:
                temp = temp.sig
            else:
                break
            num = num+1
        return num

    def ver_Col(self, emp):
        ver = False
        temp = self.raiz.sig
        while temp != None:
            if temp.emp == emp:
                ver = True
                break
            temp = temp.sig
        return ver

    def ver_Fil(self, dep):
        ver = False
        temp = self.raiz.aba
        while temp is not None:
            if temp.dep == dep:
                ver = True
                break
            temp = temp.aba
        return ver

    def cabe_hor(self, emp):
        x = 0
        temp = self.raiz.sig
        cabecera = NodoMatriz()
        cabecera.emp = emp
        cabecera.dep = emp
        if self.vacia() == True:
            self.raiz.sig = cabecera
            cabecera.ant = self.raiz
            return cabecera
        else:
            while temp != None:
                if emp < temp.emp:
                    x = 1
                    break
                if temp.sig != None:
                    temp = temp.sig
                else:
                    break
            if x == 1:
                temp.ant.sig = cabecera
                cabecera.ant = temp.ant
                cabecera.sig = temp
                temp.ant = cabecera
            if x == 0:
                temp.sig = cabecera
                cabecera.ant = temp
        return cabecera

    def cabe_vert(self, dep):
        x = 0
        temp = self.raiz.aba
        cabecera = NodoMatriz()
        cabecera.dep = dep
        cabecera.emp = dep
        if self.vacia() == True:
            self.raiz.aba = cabecera
            cabecera.arr = self.raiz
        else:
            while temp != None:
                if dep < temp.dep:
                    x = 1
                    break
                if temp.aba != None:
                    temp = temp.aba
                else:
                    break
            if x == 1:
                temp.arr.aba = cabecera
                cabecera.arr = temp.arr
                cabecera.aba = temp
                temp.arr = cabecera
            if x == 0:
                temp.aba = cabecera
                cabecera.arr = temp
        return cabecera

    def traer_Fila(self, dep):
        temp = self.raiz
        while  temp != None:
            if temp.dep is dep:
                break
            if temp.aba != None:
                temp = temp.aba
            else:
                break
        return temp

    def traer_Col(self, emp):
        temp = self.raiz
        while temp != None:
            if temp.emp == emp:
                break
            if temp.sig != None:
                temp = temp.sig
            else:
                break
        return temp

    def empresas(self, temp, nodo):
        x = 0
        while temp.aba != None :
            if nodo.dep < temp.aba.dep:
                x=1
                break
            if temp.aba != None:
                temp = temp.aba
        if x == 1:
            temp.aba.arr = nodo
            nodo.aba = temp.aba
            temp.aba = nodo
            nodo.arr = temp
        if x == 0:
            temp.aba = nodo
            nodo.arr = temp
        return nodo

    def departamentos(self, temp):
        while temp.sig != None:
            temp = temp.sig
        return temp

    def empresa_Index(self, emp):
        x = 0
        temp = self.raiz
        while temp.sig != None:
            if temp.sig.emp == emp:
                break
            x = x+1
            temp = temp.sig
        return x

    def poner_Fila(self, temp, emp, nodo):
        x = 0
        dev = None
        while temp.sig != None:
            if self.empresa_Index(emp) < self.empresa_Index(tem.sig.emp):
                x = 1
                break
            if self.empresa_Index(emp) == self.empresa_Index(temp.sig.emp):
                x = 2
                break
            if temp.sig != None:
                temp = temp.sig
            else:
                break
        if x == 1:
            temp.sig.ant = nodo
            nodo.sig = temp.sig
            temp.sig = nodo
            nodo.ant = temp
            dev = nodo
        if x == 2:
            dev = None
            self.poner_adl(temp.sig, nodo)
        return dev

    def poner_adl(self, temp, nodo):
        while True:
            if temp.ad == None:
                break
        temp.ad = nodo
        nodo.atr = temp
        return nodo

    def poner_Col(self, temp, nodo):
        x = 0
        dev = None
        while temp.aba != None:
            if nodo.dep < temp.aba.dep:
                x = 1
                break
            if temp.aba != None:
                temp = temp.aba
        if x == 1:
            temp.aba.arr = nodo
            nodo.aba = temp.aba
            temp.aba = nodo
            nodo.arr = temp
        if x == 0:
            temp.aba = nodo
            nodo.arr = temp
        return nodo

    def inicio_sesion(self, usuario, contra, emp, dep):
        col = self.traer_Col(emp)
        fil = self.traer_Fila(dep)
        resp = False
        temp = col.aba
        while temp != None:
            if temp.dep == dep and temp.emp == emp:
                if temp.per.usuario == usuario and temp.per.contra == contra:
                    resp = True
                    break
                else:
                    # resp = busca_adl(temp, usuario, contra)
                    break
            if temp.aba != None:
                temp = temp.aba
            else:
                break
        return resp

    def busca_adl(self, temp, usuario, contra):
        temp2 = temp.ad
        resp = False
        while temp2 != None:
            if temp2.per.usuario == usuario and temp2.per.contra == contra:
                resp = True
                break
            if temp2.ad != None:
                temp2 = temp2.ad
            else:
                break
        return resp

    def usuario_rep(self, usuario, emp, dep):
        col = self.traer_Col(emp)
        fil = self.traer_Fila(dep)
        resp = False
        temp = col.aba
        while temp != None:
            if temp.dep == dep and temp.emp == emp:
                if temp.per.usuario == usuario:
                    resp = True
                    break
                else:
                    resp = self.rep_adl(temp, usuario)
                    break
            if temp.aba != None:
                temp = temp.aba
            else:
                break
        return resp

    def rep_adl(self, temp, usuario):
        temp2 = temp.ad
        resp = False
        while temp2 != None:
            if temp2.per.usuario == usuario:
                resp = True
                break
            if temp2.ad != None:
                temp2 = temp2.ad
            else:
                break
        return resp


    def registrarUsuario(self, emp, dep, nombre, usuario, contra):
        ingreso = NodoMatriz()
        ingreso.dep = dep
        ingreso.emp = emp
        ingreso.per = Usuario(usuario, contra, nombre)
        # AQUI VA EL AVL PARA METERLO AL NodoMatriz
        colum = self.ver_Col(emp)
        fil = self.ver_Fil(dep)
        if colum == False and fil == False:
            self.insercion_1(emp, dep, ingreso)
            return None
        if colum == False and fil == True:
            self.insercion_1(emp, dep, ingreso)
            return None
        if colum == True and fil == False:
            self.insercion_3(emp, dep, ingreso)
            return None
        if colum == True and fil == True:
            self.insercion_4(emp, dep, ingreso)
            return None

    def insercion_1(self, emp, dep, ingreso):
        col = self.cabe_hor(emp)
        fil = self.cabe_vert(dep)
        col.aba = ingreso
        ingreso.arr = col
        fil.sig = ingreso
        ingreso.ant = fil

    def insercion_2(self, emp, dep, ingreso):
        col = self.cabe_hor(emp)
        fil = self.traer_Fila(dep)
        pos = self.departamentos(fil)
        col.aba = ingreso
        ingreso.arr = col
        pos.sig = ingreso
        ingreso.ant = pos

    def insercion_3(self, emp, dep, ingreso):
        col = self.traer_Col(emp)
        fil = self.cabe_vert(dep)
        temp = self.empresas(col, ingreso)
        fil.sig = temp
        temp.ant = fil

    def insercion_4(self, emp, dep, ingreso):
        col = self.traer_Col(emp)
        col.emp = emp
        fil = self.traer_Fila(dep)
        fil.dep = dep
        aux = self.poner_Fila(fil, emp, ingreso)
        if aux != None:
            self.poner_Col(col, aux)

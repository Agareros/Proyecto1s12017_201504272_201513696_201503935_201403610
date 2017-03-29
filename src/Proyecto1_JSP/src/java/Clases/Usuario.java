/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;
import Servlet.IniciarSesion;
/**
 *
 * @author joseph
 */
public class Usuario {
    String nombre;
    String usuario;
    String contraseña;
    String departamento;
    String empresa;

    public Usuario(String usuario, String contraseña, String departamento, String empresa) {
        this.usuario = usuario;
        this.contraseña = contraseña;
        this.departamento = departamento;
        this.empresa = empresa;
    }

    public Usuario(String nombre, String usuario, String contraseña, String departamento, String empresa) {
        this.nombre = nombre;
        this.usuario = usuario;
        this.contraseña = contraseña;
        this.departamento = departamento;
        this.empresa = empresa;
    }
    
    public Usuario(){
        
    }
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getContraseña() {
        return contraseña;
    }

    public void setContraseña(String contraseña) {
        this.contraseña = contraseña;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    public String getEmpresa() {
        return empresa;
    }

    public void setEmpresa(String empresa) {
        this.empresa = empresa;
    }
    
    
}

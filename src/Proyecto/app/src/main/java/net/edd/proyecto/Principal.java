package net.edd.proyecto;

import android.content.Intent;
import android.net.http.HttpResponseCache;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.logging.Level;
import java.util.logging.Logger;
import android.widget.EditText;
import android.widget.TextView;
import com.squareup.okhttp.internal.http.HttpConnection;
import com.squareup.okhttp.RequestBody;
import org.apache.http.auth.MalformedChallengeException;
import org.apache.http.client.HttpClient;
import org.json.JSONException;
import org.json.JSONObject;
import org.w3c.dom.Text;
import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONException;
import org.json.JSONObject;



public class Principal extends AppCompatActivity {
    EditText texto, texto2, texto3, texto4;
    Button siguiente;
    Button hello;
    HttpConnection connection;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_principal);

        hello = (Button) findViewById(R.id.hola);
        texto = (EditText) findViewById(R.id.textUsuario);
        texto2 = (EditText) findViewById(R.id.textContra);
        texto3 = (EditText) findViewById(R.id.textEmpresa);
        texto4 = (EditText) findViewById(R.id.textDepartamento);

        siguiente = (Button) findViewById(R.id.ingresar);

        siguiente.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent siguiente = new Intent(Principal.this, Menu.class);
                startActivity(siguiente);

            }

        });
            public String enviarGET(String usu, String contra, String emp, String depto){
        URL url = null;
        String linea="";
        int respuesta =0;
        StringBuilder resul=null;

        try {
            url new URL("http://192.168.56.1/Webservice/valida.php?usu="+usu+"&pas="+contra);

        }catch (Exception e) {}



    }
};

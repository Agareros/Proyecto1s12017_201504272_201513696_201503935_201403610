package net.edd.proyecto;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Menu extends AppCompatActivity {
    Button irRenta;
    Button irDev;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        irRenta = (Button)findViewById(R.id.Rentar);
        irRenta.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){

                Intent irRenta = new Intent(Menu.this, Renta.class);
                startActivity(irRenta);
            }

        });
        irDev = (Button)findViewById(R.id.Regdev);
        irDev.setOnClickListener(new View.OnClickListener(){
         @Override
            public void onClick(View v) {
             Intent irDev = new Intent (Menu.this, Devolucion.class);
             startActivity(irDev);
         }
        });
    }
}

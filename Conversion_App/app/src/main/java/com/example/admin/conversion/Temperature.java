package com.example.admin.conversion;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Temperature extends AppCompatActivity {
    EditText et1,et2,et3;
Button bt1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_temperature);
        et1=findViewById(R.id.editText3);
        et2=findViewById(R.id.editText4);
        et3=findViewById(R.id.editText6);
        bt1=findViewById(R.id.button);
        bt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (et1.isFocused()) {
                    double fah, cel,kel;
                    fah = Double.parseDouble(et1.getText().toString());
                    cel = ((fah - 32) * 5) / 9;
                    kel=(((fah-32)*5)/9)+273.15;
                    et2.setText(String.valueOf(cel));
                    et3.setText(String.valueOf(kel));
                }
                else if (et2.isFocused()) {
                    double fah, cel,kel;
                    cel = Double.parseDouble(et2.getText().toString());
                    fah = (cel * 1.8) + 32;
                    kel=cel+273.15;
                    et1.setText(String.valueOf(fah));
                    et3.setText(String.valueOf(kel));
                }
                else if (et3.isFocused()) {
                    double fah, cel,kel;
                    kel = Double.parseDouble(et3.getText().toString());
                    fah= (((kel - 273.15)*9)/5) + 32;
                    cel=kel-273.15;
                    et1.setText(String.valueOf(fah));
                    et2.setText(String.valueOf(cel));
                }
            }
        });
        findViewById(R.id.button2).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent main=new Intent(getBaseContext(),MainActivity.class);
                startActivity(main);
            }
        });
    }
}

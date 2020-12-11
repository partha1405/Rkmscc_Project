package com.example.admin.conversion;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

public class MainActivity extends AppCompatActivity {
//String[] mainList={"Area","Frequency","Length","Temperature","Time"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
       findViewById(R.id.imageButton2).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent tempe=new Intent(getBaseContext(),Temperature.class);
                startActivity(tempe);
            }
        });
        findViewById(R.id.imageButton4).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent len=new Intent(getBaseContext(),Length.class);
                startActivity(len);
            }
        });
       /* ArrayAdapter<String> arrayAdapter=new ArrayAdapter<>(MainActivity.this,android.R.layout.simple_list_item_1,mainList);
        Spinner spinner=findViewById(R.id.spinner);
        spinner.setAdapter(arrayAdapter);
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                switch (i) {
                    case '0':
                        String[] area={"Squre kilometre","Squre metre","Squre mile","Squre yard"};
                        ArrayAdapter<String> arrayAdapter2=new ArrayAdapter<>(MainActivity.this,android.R.layout.simple_list_item_1,area);
                        Spinner spinner2=findViewById(R.id.spinner2);
                        spinner2.setAdapter(arrayAdapter2);
                        spinner2.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
                            @Override
                            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {

                            }

                            @Override
                            public void onNothingSelected(AdapterView<?> adapterView) {

                            }
                        });
                        break;
                    case '1':
                        String[] frequency={"Hertz","Kilohertz","Megahertz","Gigahertz"};
                        ArrayAdapter<String> arrayAdapter3=new ArrayAdapter<>(MainActivity.this,android.R.layout.simple_list_item_1,frequency);
                        Spinner spinner3=findViewById(R.id.spinner2);
                        spinner3.setAdapter(arrayAdapter3);
                        break;
                    case '2':
                        String[] length={"Kilometre","Metre","Centimetre","Milimetre"};
                        ArrayAdapter<String> arrayAdapter4=new ArrayAdapter<>(MainActivity.this,android.R.layout.simple_list_item_1,length);
                        Spinner spinner4=findViewById(R.id.spinner2);
                        spinner4.setAdapter(arrayAdapter4);
                        break;
                    case '3':
                        String[] temperature={"Centigrade","Fahrenheit","Kelvin",};
                        ArrayAdapter<String> arrayAdapter5=new ArrayAdapter<>(MainActivity.this,android.R.layout.simple_list_item_1,temperature);
                        Spinner spinner5=findViewById(R.id.spinner2);
                        spinner5.setAdapter(arrayAdapter5);
                        break;
                    case '4':
                        String[] time={"Second","Minute","Hour",};
                        ArrayAdapter<String> arrayAdapter6=new ArrayAdapter<>(MainActivity.this,android.R.layout.simple_list_item_1,time);
                        Spinner spinner6=findViewById(R.id.spinner2);
                        spinner6.setAdapter(arrayAdapter6);
                        break;
                    default :
                        break;
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        }); */
    }
}

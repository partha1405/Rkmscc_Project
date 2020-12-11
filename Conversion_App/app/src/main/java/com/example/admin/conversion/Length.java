package com.example.admin.conversion;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

public class Length extends AppCompatActivity {
TextView result;
EditText Len_Value;
RadioButton f2i,m2cm,km2m,y2f;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_length);
findViewById(R.id.button5).setOnClickListener(new View.OnClickListener() {
    @Override
    public void onClick(View view) {
        Intent mn=new Intent(getBaseContext(),MainActivity.class);
        startActivity(mn);
    }
});
    }

    public void length(View view){
        result=findViewById(R.id.textView3);
        Len_Value=findViewById(R.id.editText);
        double d= Double.parseDouble(String.valueOf(Len_Value.getText()));
        f2i=findViewById(R.id.radioButton);
        m2cm=findViewById(R.id.radioButton2);
        km2m=findViewById(R.id.radioButton3);
        y2f=findViewById(R.id.radioButton4);
        if(f2i.isChecked()){
            result.setText(foottoinch(d)+"Inch");
        }
        else if(m2cm.isChecked()){
            result.setText(metertocentimetre(d)+"Centimetre");
        }
        else if(km2m.isChecked()){
            result.setText(kilotometre(d)+"Metre");
        }
        else if(y2f.isChecked()){
            result.setText(yardtofoot(d)+"Foot");
        }
    }
    private double foottoinch(double vald){return (vald*12);}
    private double metertocentimetre(double valb){return (valb*100);}
    private double kilotometre(double valc){return (valc*1000);}
    private double yardtofoot(double vala){return (vala*3);}

}

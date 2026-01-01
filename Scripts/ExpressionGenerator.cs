using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExpressionGenerator : MonoBehaviour
{
    public  TMP_Text TestText;
    public TMP_InputField lvl;
    public struct Exprestion
{
    public Exprestion(int difficulty , string Operations)
    {
        X = -1;
        Y = -1;
        operation ='%';
        answer = -1;
        wrong = -1;
        
        if(difficulty == 1) {
            
            operation = Operations[Random.Range(0,Operations.Length)];
            if(operation == '/'){
                X = Random.Range(0,3);
                Y = Random.Range(1,3);
                int temp = X*Y;
                answer = X;
                X = temp;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,5);
                }
            }
            if(operation == '+'){
                X = Random.Range(0,10);
                Y = Random.Range(0,10);
                answer = X + Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,20);
                }
            }
            if(operation == '-'){
                X = Random.Range(0,10);
                Y = Random.Range(0,10);
                if(X >= Y){
                    answer = X-Y;
                }
                else {
                    answer = Y-X;
                    int temp = X;
                    X = Y;
                    Y = temp;
                }
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,10);
                }
            }
            if(operation == '*'){
                X = Random.Range(0,3);
                Y = Random.Range(0,3);
                answer = X*Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,9);
                }
            }
        }
        if(difficulty == 2) {
            operation = Operations[Random.Range(0,Operations.Length)];
            if(operation == '/'){
                X = Random.Range(0,5);
                Y = Random.Range(1,5);
                int temp = X*Y;
                answer = X;
                X = temp;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,5);
                }
            }
            if(operation == '+'){
                X = Random.Range(0,20);
                Y = Random.Range(0,20);
                answer = X + Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,40);
                }
            }
            if(operation == '-'){
                X = Random.Range(0,20);
                Y = Random.Range(0,20);
                if(X >= Y){
                    answer = X-Y;
                }
                else {
                    answer = Y-X;
                    int temp = X;
                    X = Y;
                    Y = temp;
                }
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,20);
                }
            }
            if(operation == '*'){
                X = Random.Range(0,5);
                Y = Random.Range(0,5);
                answer = X*Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,25);
                }
            }
        }
        if(difficulty == 3) {
            operation = Operations[Random.Range(0,Operations.Length)];
            if(operation == '/'){
                X = Random.Range(0,12);
            Y = Random.Range(1,12);
                int temp = X*Y;
                answer = X;
                X = temp;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(0,15);
                }
            }
            if(operation == '+'){
                X = Random.Range(0,40);
                Y = Random.Range(0,40);
                answer = X + Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(20,80);
                }
            }
            if(operation == '-'){
                X = Random.Range(0,40);
                Y = Random.Range(0,40);
                if(X >= Y){
                    answer = X-Y;
                }
                else {
                    answer = Y-X;
                    int temp = X;
                    X = Y;
                    Y = temp;
                }
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(5,40);
                }
            }
            if(operation == '*'){
                X = Random.Range(0,12);
            Y = Random.Range(0,12);
                answer = X*Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(answer-20,answer+20);
                }
            }
        }
        if(difficulty == 4) {
            operation = Operations[Random.Range(0,Operations.Length)];
            if(operation == '/'){
                X = Random.Range(1,20);
                Y = Random.Range(0,20);
                int temp = X*Y;
                answer = X;
                X = temp;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(5,20);
                }
            }
            if(operation == '+'){
                X = Random.Range(0,80);
                Y = Random.Range(0,80);
                answer = X + Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(20,160);
                }
            }
            if(operation == '-'){
                X = Random.Range(0,80);
                Y = Random.Range(0,80);
                if(X >= Y){
                    answer = X-Y;
                }
                else {
                    answer = Y-X;
                    int temp = X;
                    X = Y;
                    Y = temp;
                }
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(10,80);
                }
            }
            if(operation == '*'){
                X = Random.Range(0,20);
                Y = Random.Range(0,20);
                answer = X*Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(50,400);
                }
            }
        }
        if(difficulty == 5) {
            operation = Operations[Random.Range(0,Operations.Length)];
            if(operation == '/'){
                X = Random.Range(0,30);
                Y = Random.Range(1,30);
                int temp = X*Y;
                answer = X;
                X = temp;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(5,30);
                }
            }
            if(operation == '+'){
                X = Random.Range(0,160);
                Y = Random.Range(0,160);
                answer = X + Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(20,320);
                }
            }
            if(operation == '-'){
                X = Random.Range(0,160);
                Y = Random.Range(0,160);
                if(X >= Y){
                    answer = X-Y;
                }
                else {
                    answer = Y-X;
                    int temp = X;
                    X = Y;
                    Y = temp;
                }
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(10,160);
                }
            }
            if(operation == '*'){
                X = Random.Range(0,30);
                Y = Random.Range(0,30);
                answer = X*Y;
                while(wrong == answer || wrong <= 0){
                    wrong = Random.Range(30,500);
                }
            }
        }

    }

    public int X { get; }
    public int Y { get; }

    public char operation { get;}

    public  int answer { get; }

    public  int wrong { get; }

    public override string ToString() => $"({X}, {Y})";
}


public void test (){
    var test = new Exprestion(int.Parse(lvl.text ),"+-*/"); 
    TestText.text =  test.X +  " " + test.operation + " "+ test.Y + " = " + test.answer +", !=" +test.wrong; 
}
}

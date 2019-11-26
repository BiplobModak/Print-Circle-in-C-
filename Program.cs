using System;

namespace cricle_blog
{
    class Program
    {
        /* we know that,
            (x-h)^2+(y-k)^2 = r^2 (equation of cricle)
                                    here,
                                        slope = radious
                                        x = i
                                        y = j
                                        h= k
                                        k=l

            
        here i take loop condition 2* 
        
        
        */

        static void Main(string[] args)
        {
            
            int  k= 20, l=20;//loop variable i,j and k is radious of cricle 
            

            Program program = new Program(); // create a Program class object for access Nonstatic methon in Static area
            
            Console.WriteLine("\n\nfull cricle start here\n\n");

            program.fullCricle(k,l);
            Console.WriteLine("\n\nfirst quatar start here\n\n");
            program.firstQuater(k,l);

            Console.WriteLine("\n\nsecond quatar start here\n\n");
            program.secondQuater(k,l);
            Console.WriteLine("\n\nthard quatar start here\n\n");
            
           program.thardQuater(k,l);
            Console.WriteLine("\n\nthard quatar start here\n\n");
           program.fourthQuater(k,l);
            
   

            

        }

        void fullCricle(int k, int l){
            int i,j;//loop variable i,j and k is radious of cricle 
            double slope;

            // full cricle start
       
            for(i = 0;i <= 2*k ;i++){//horezontal  print
                for(j = 0; j <= 2*k ;j++){// varticak print 
                    slope = Math.Sqrt((i - k) * (i - k) + (j - l) * (j - l)); //cricle equeation
                    // https://www.purplemath.com/modules/sqrcircle.htm here i get this equation
                    
                   
                    if( slope> k ){//checking the equation for printing *, if slop is > k then it print space else print *
                        Console.Write(" ");


                    }
                    else{
                        Console.Write("*");
                    }

                }
                Console.WriteLine("");
                
            }
            //full cricle end
        }


         //1st quatar start here
        void firstQuater(int k, int l){
            double slope;
            int i,j;
           
            for(i = 1; i <= 2*k ; i++){                                               //horezontal  print
                for(j = 1; j <=2*k ;j++){                                            // varticak print 
                    slope = Math.Sqrt((i - 2*k) * (i - 2*k) + (j- 2*k) * (j - 2*k)); //cricle equeation

                   
                   if(slope>k ){                                                      //checking the equation 
                                                            //for printing *, if slop is > k then it print space else print *
                                               
                        Console.Write(" ");


                    }
                    else{
                        Console.Write("*");

                        
                    }

                }
                Console.WriteLine("");
                
            }

        }

 //2nd quatar start here
        void secondQuater(int k, int l){
            double slope;
            int i,j;
           
            for(i = 1;i <=2*k ;i++){//horezontal  print
                for(j = 2*k; j >=1 ;j--){// varticak print 
                    slope = Math.Sqrt((i - 2*k) * (i - 2*k) + (j- 2*k) * (j - 2*k)); //cricle equeation

                   
                   if(slope>k ){//checking the equation for printing *, if slop is > k then it print space else print *
                        
                        
                        Console.Write(" ");


                    }
                    else{
                        Console.Write("*");

                        
                    }

                }
                Console.WriteLine("");
                
            }

        }


         //3th quatar start here
        void thardQuater(int k, int l){
            double slope;
            int i,j;
            //frist quatar start
            for(i = 2*k;i >= 1 ;i--){//horezontal  print
                for(j = 1; j <=2*k ;j++){// varticak print 
                    slope = Math.Sqrt((i - 2*k) * (i - 2*k) + (j- 2*k) * (j - 2*k)); //cricle equeation

                   
                   if(slope>k ){//checking the equation for printing *, if slop is > k then it print space else print *
                        
                        
                        Console.Write(" ");


                    }
                    else{
                        Console.Write("*");

                        
                    }

                }
                Console.WriteLine("");
                
            }

        }


        //4th quatar start here
        void fourthQuater(int k, int l){
            double slope;
            int i,j;
            //frist quatar start
            for(i = 2*k;i >= 1 ;i--){//horezontal  print
                for(j = 2*k; j >=1 ;j--){// varticak print 
                    slope = Math.Sqrt((i - 2*k) * (i - 2*k) + (j- 2*k) * (j - 2*k)); //cricle equeation

                   
                   if(slope>k ){//checking the equation for printing *, if slop is > k then it print space else print *
                        
                        
                        Console.Write(" ");


                    }
                    else{
                        Console.Write("*");

                        
                    }

                }
                Console.WriteLine("");
                
            }

        }
    }
}

package sample;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.Group;
import javafx.stage.Stage;
import javafx.scene.text.Font;
import javafx.scene.text.Text;
import javafx.scene.text.FontWeight;
import javafx.scene.control.TextField;
import javafx.scene.control.ComboBox;
import javafx.scene.layout.BackgroundFill;
import javafx.scene.layout.Background;
import javafx.scene.input.KeyCode;
import javafx.scene.paint.Color;
import javafx.geometry.Insets;
import javafx.scene.shape.StrokeLineJoin;
import javafx.scene.layout.Border;
import javafx.scene.layout.BorderStroke;
import javafx.scene.layout.BorderStrokeStyle;
import javafx.scene.shape.StrokeType;
import javafx.scene.layout.CornerRadii;
import javafx.application.Platform;

import java.util.*;
import java.io.*;

import javafx.collections.ObservableList;
import javafx.collections.FXCollections;


public class Main extends Application {

    final static double INTEREST_RATE_MIN = 2.0;
    final static double INTEREST_RATE_MAX = 8.0;
    final static int MIN_TERM = 1;
    final static int MAX_TERM = 60;

    //Combobox objects
    private ComboBox<Integer> termCombo = null;
    private ComboBox<Double> interestRateCombo = null;

    //Arraylist to initialize comboboxes
    private List<Integer> termList = new ArrayList<Integer>();
    private List<Double> interestRateList = new ArrayList<Double>();

    //Element pointers
    final int TERM_ELEMENT = 0;
    final int INTEREST_ELEMENT = 1;

    //File constants
    private final String FILE_TERM = "loan_terms.txt";
    private final String FILE_INTEREST = "annual_interest_rates.txt";


    @Override
    public void start(Stage primaryStage) throws Exception {
        //Set title
        primaryStage.setTitle("Loan Payment and Eligibility Calculator Form");

        //Create calc and exit buttons
        Button calcBtn = new Button();
        Button cancelBtn = new Button();

        //Cancel button event
        cancelBtn.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent Event) {
                System.exit(-1);
            }
        });
        //Set button text
        calcBtn.setText("Calc Payment");
        cancelBtn.setText("Cancel");

        //Set locations for buttons
        calcBtn.setLayoutX(15);
        calcBtn.setLayoutY(210);

        cancelBtn.setLayoutX(120);
        cancelBtn.setLayoutY(210);

        //Create Text objects with location and text to display.
        Text salaryText = new Text(15, 30, "Salary and Wages:");
        Text interestText = new Text(15, 70, "Interest Income:");
        Text investmentText = new Text(15, 110, "Investment Income:");
        Text otherIncomeText = new Text(15, 150, "Other Income:");
        Text totalIncomeText = new Text(15, 190, "Total Income:");
        Text annualInterestText = new Text(320, 30, "Annual Interest Rate(n.nnn%):");
        Text termText = new Text(320, 70, "Term in Years:");
        Text loanAmtText = new Text(320, 110, "Loan Amount:");
        Text monthlyPaymentText = new Text(320, 150, "Monthly Payment:");
        Text totalPaymentsText = new Text(320, 190, "Total Payments Over Life of Loan:");
        Text eligibilityText = new Text();
        Text percentageText = new Text();

        //Settings fonts for text
        salaryText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        interestText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        investmentText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        otherIncomeText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        totalIncomeText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        annualInterestText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        termText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        loanAmtText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        monthlyPaymentText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        totalPaymentsText.setFont(Font.font("time new roman", FontWeight.SEMI_BOLD, 14));
        eligibilityText.setFont(Font.font("time new roman", FontWeight.BOLD, 14));
        percentageText.setFont(Font.font("time new roman", FontWeight.BOLD, 14));

        //Set location for event based text box
        eligibilityText.setLayoutX(320);
        eligibilityText.setLayoutY(230);
        percentageText.setLayoutX(320);
        percentageText.setLayoutY(250);

        //Create textfield object
        TextField salaryTxtField = new TextField();
        TextField interestTxtField = new TextField();
        TextField investmentTxtField = new TextField();
        TextField otherIncomeTxtField = new TextField();
        TextField totalIncomeTxtField = new TextField();
        TextField loanAmtTxtField = new TextField();
        TextField monthlyPaymentTxtField = new TextField();
        TextField totalPaymentsTxtField = new TextField();

        //Place textfield objects
        salaryTxtField.setLayoutX(150);
        salaryTxtField.setLayoutY(15);

        interestTxtField.setLayoutX(150);
        interestTxtField.setLayoutY(55);

        investmentTxtField.setLayoutX(150);
        investmentTxtField.setLayoutY(95);

        otherIncomeTxtField.setLayoutX(150);
        otherIncomeTxtField.setLayoutY(135);

        totalIncomeTxtField.setLayoutX(150);
        totalIncomeTxtField.setLayoutY(175);

        loanAmtTxtField.setLayoutX(550);
        loanAmtTxtField.setLayoutY(95);

        monthlyPaymentTxtField.setLayoutX(550);
        monthlyPaymentTxtField.setLayoutY(135);

        totalPaymentsTxtField.setLayoutX(550);
        totalPaymentsTxtField.setLayoutY(175);

        //Key Press notfication.
        Text keyPressNotification = null;

        //Background for text boxes
        Color redBackgroundColor = Color.rgb(255, 128, 128, 0.5);
        BackgroundFill redBackgroundFill = new BackgroundFill(redBackgroundColor, null, new Insets(2, 2, 2, 2));
        Background redBackground = new Background(redBackgroundFill);

        //White default background
        Color whiteColor = Color.rgb(255, 255, 255, 1.00);
        BackgroundFill whiteBackgroundFill = new BackgroundFill(whiteColor, null, new Insets(2, 2, 2, 2));
        Background whiteBackground = new Background(whiteBackgroundFill);

        //White background border stroke
        Color borderColor = Color.rgb(164, 164, 164, .75);
        BorderStrokeStyle solidRoundStrokeStyle = new BorderStrokeStyle(StrokeType.OUTSIDE, StrokeLineJoin.ROUND, null, 1.0, 0.0, null);
        CornerRadii radius5 = new CornerRadii(5.0);
        BorderStroke borderStroke = new BorderStroke(borderColor, solidRoundStrokeStyle, radius5, BorderStroke.THIN);
        Border grayBorder = new Border(borderStroke);

        //Set settings for combo boxes
        termCombo = new ComboBox<Integer>();
        termCombo.setEditable(false);
        termCombo.setPrefWidth(150);
        termCombo.setPromptText("Select term(years).");

        interestRateCombo = new ComboBox<Double>();
        interestRateCombo.setEditable(false);
        interestRateCombo.setPrefWidth(150);
        interestRateCombo.setPromptText("Select interest rate(percent).");

        //Method call to fill combo boxes with file material.
        getData();

        //Copy array list into observable list
        ObservableList<Integer> olTerm = FXCollections.observableArrayList( termList );
        ObservableList<Double> olInterestRate = FXCollections.observableArrayList( interestRateList );

        //Set items for combo boxes.
        termCombo.setItems(olTerm);
        interestRateCombo.setItems(olInterestRate);

        //Set positioning for combo boxes
        termCombo.setLayoutX(550);
        termCombo.setLayoutY(55);

        interestRateCombo.setLayoutX(550);
        interestRateCombo.setLayoutY(15);

        //Create group to add all objects to a group.
        Group root = new Group();
        //Add buttons
        root.getChildren().addAll(calcBtn, cancelBtn);
        //Add text displays
        root.getChildren().addAll(salaryText, interestText, investmentText, otherIncomeText, totalIncomeText,
                annualInterestText, termText, loanAmtText, monthlyPaymentText, totalPaymentsText);
        //Add text fields
        root.getChildren().addAll(salaryTxtField, interestTxtField, investmentTxtField, otherIncomeTxtField,
                totalIncomeTxtField, loanAmtTxtField, monthlyPaymentTxtField, totalPaymentsTxtField);

        //Add combo boxes
        root.getChildren().addAll(termCombo, interestRateCombo);
        //Add event handled text display.
        root.getChildren().addAll(eligibilityText, percentageText);


        primaryStage.setScene(new Scene(root, 750, 270));
        primaryStage.show();

        //Salary text field key event
        salaryTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                salaryTxtField.setBackground(whiteBackground);
                salaryTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (salaryTxtField.getBackground() == redBackground) {
                    salaryTxtField.clear();
                }
                salaryTxtField.setBackground(whiteBackground);
                salaryTxtField.setBorder(grayBorder);
            } else {
                salaryTxtField.setBackground(redBackground);
            }
        });

        //Interest text field key event
        interestTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                interestTxtField.setBackground(whiteBackground);
                interestTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (interestTxtField.getBackground() == redBackground) {
                    interestTxtField.clear();
                }
                interestTxtField.setBackground(whiteBackground);
                interestTxtField.setBorder(grayBorder);
            } else {
                interestTxtField.setBackground(redBackground);
            }
        });

        //investment text field key event
        investmentTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                investmentTxtField.setBackground(whiteBackground);
                investmentTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (investmentTxtField.getBackground() == redBackground) {
                    investmentTxtField.clear();
                }
                investmentTxtField.setBackground(whiteBackground);
                investmentTxtField.setBorder(grayBorder);
            } else {
                investmentTxtField.setBackground(redBackground);
            }
        });

        //other income text field key event
        otherIncomeTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                otherIncomeTxtField.setBackground(whiteBackground);
                otherIncomeTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (otherIncomeTxtField.getBackground() == redBackground) {
                    otherIncomeTxtField.clear();
                }
                otherIncomeTxtField.setBackground(whiteBackground);
                otherIncomeTxtField.setBorder(grayBorder);
            } else {
                otherIncomeTxtField.setBackground(redBackground);
            }
        });

        //total income text field key event
        totalIncomeTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                totalIncomeTxtField.setBackground(whiteBackground);
                totalIncomeTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (totalIncomeTxtField.getBackground() == redBackground) {
                    totalIncomeTxtField.clear();
                }
                totalIncomeTxtField.setBackground(whiteBackground);
                totalIncomeTxtField.setBorder(grayBorder);
            } else {
                totalIncomeTxtField.setBackground(redBackground);
            }
        });

        //loan amount text field key event
        loanAmtTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                loanAmtTxtField.setBackground(whiteBackground);
                loanAmtTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (loanAmtTxtField.getBackground() == redBackground) {
                    loanAmtTxtField.clear();
                }
                loanAmtTxtField.setBackground(whiteBackground);
                loanAmtTxtField.setBorder(grayBorder);
            } else {
                loanAmtTxtField.setBackground(redBackground);
            }
        });

        //monthly payment text field key event
        monthlyPaymentTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                monthlyPaymentTxtField.setBackground(whiteBackground);
                monthlyPaymentTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (monthlyPaymentTxtField.getBackground() == redBackground) {
                    monthlyPaymentTxtField.clear();
                }
                monthlyPaymentTxtField.setBackground(whiteBackground);
                monthlyPaymentTxtField.setBorder(grayBorder);
            } else {
                monthlyPaymentTxtField.setBackground(redBackground);
            }
        });

        //total payment text field key event
        totalPaymentsTxtField.setOnKeyPressed(d -> {
            if (d.getCode() == KeyCode.BACK_SPACE) {
                totalPaymentsTxtField.setBackground(whiteBackground);
                totalPaymentsTxtField.setBorder(grayBorder);
            } else if (d.getCode() == KeyCode.DIGIT0 || d.getCode() == KeyCode.DIGIT1 ||
                    d.getCode() == KeyCode.DIGIT2 || d.getCode() == KeyCode.DIGIT3 ||
                    d.getCode() == KeyCode.DIGIT4 || d.getCode() == KeyCode.DIGIT5 ||
                    d.getCode() == KeyCode.DIGIT6 || d.getCode() == KeyCode.DIGIT7 ||
                    d.getCode() == KeyCode.DIGIT8 || d.getCode() == KeyCode.DIGIT9) {
                if (totalPaymentsTxtField.getBackground() == redBackground) {
                    totalPaymentsTxtField.clear();
                }
                totalPaymentsTxtField.setBackground(whiteBackground);
                totalPaymentsTxtField.setBorder(grayBorder);
            } else {
                totalPaymentsTxtField.setBackground(redBackground);
            }
        });


        //Calc Payment button event
        calcBtn.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent Event) {
                try {

                    //Get values from text fields.
                    double salary = Double.parseDouble(salaryTxtField.getText());
                    //Checks for valid salary
                    if (salary <= 0) {
                        eligibilityText.setText("Please enter a valid salary.");
                        return;
                    }

                    double interestIncome = Double.parseDouble(interestTxtField.getText());
                    //Checks for valid interest income
                    if (interestIncome < 0) {
                        eligibilityText.setText("Please enter a valid interest income, if none, enter 0.");
                        return;
                    }

                    double investmentIncome = Double.parseDouble(investmentTxtField.getText());
                    //Checks for valid investment income
                    if (investmentIncome < 0) {
                        eligibilityText.setText("Please enter a valid investment income, if none, enter 0.");
                        return;
                    }
                    double otherIncome = Double.parseDouble(otherIncomeTxtField.getText());
                    //Checks for valid other income
                    if (otherIncome < 0) {
                        eligibilityText.setText("Please enter a valid number, if none, enter 0.");
                        return;
                    }

                    double totalIncome = Double.parseDouble(totalIncomeTxtField.getText());
                    //Checks for valid total income, if all other income inputs are correctly entered, calcs total income for user.
                    if (totalIncome <= 0 || totalIncome != (salary + interestIncome + investmentIncome + otherIncome)) {
                        eligibilityText.setText("Calculating proper total income..");
                        totalIncome = salary + interestIncome + investmentIncome + otherIncome;
                        totalIncomeTxtField.setText(String.valueOf(totalIncome));
                        Thread.sleep(1000);
                    }

                    //Get interest rate and term values from combo boxes.
                    double annualInterestRate = interestRateCombo.getValue();
                    int term = termCombo.getValue();

                    double loanAmount = Double.parseDouble(loanAmtTxtField.getText());
                    //Gets a valid loan amount.
                    if (loanAmount <= 0) {
                        eligibilityText.setText("Please enter a valid loan amount.");
                        return;
                    }

                    double monthlyPayment = Double.parseDouble(monthlyPaymentTxtField.getText());
                    //Gets a valid monthly payment.
                    if (monthlyPayment <= 0) {
                        eligibilityText.setText("Please enter a valid monthly payment.");
                        return;
                    }

                    int totalAmtOfPayments = Integer.parseInt(totalPaymentsTxtField.getText());
                    //Gets a valid amount of payments.
                    if (totalAmtOfPayments <= 0) {
                        eligibilityText.setText("Please enter a valid amount of payments");
                        return;
                    }

                    //Creates loan object with user values
                    Loan loan = new Loan(salary, interestIncome, investmentIncome, otherIncome,
                            totalIncome, annualInterestRate, term, loanAmount, monthlyPayment,
                            totalAmtOfPayments);

                    loan.calcPeriodicPayment();
                    loan.determineIfEligible();


                    if (loan.getEligibility()) {
                        eligibilityText.setText("It looks like you are eligible for this loan!");
                        percentageText.setText("The loan payment was only " + loan.getPercentOfIncome() + "% of your monthly income!");
                    } else if (!loan.getEligibility()) {
                        eligibilityText.setText("Sorry you were not eligible for this loan.");
                        percentageText.setText("The loan payment was " + loan.getPercentOfIncome() + "% of your monthly income.");

                    }


                } catch (Exception e) { //Catches any non integer values or nulls.
                    System.out.println("Wrong input type received.");
                    eligibilityText.setText("Please enter proper values.");

                }


            }
        });

    }

//}




    public static void main(String[] args)
    {
        launch(args);
    }

    public void getData() {

        String inputValue       = "";

        //Term file, filereader, and buffered reader.
        File fileObjectTerm         = null;
        FileReader frObjectTerm     = null;
        BufferedReader brObjectTerm = null;

        //Interest Rate file objects.
        File fileObjectInterest         = null;
        FileReader frObjectInterest     = null;
        BufferedReader brObjectInterest = null;

        try { //Try-catch for term file.

            //Initialize term file reading components.
            fileObjectTerm = new File("E:\\JavaFXPrograms\\homework5\\src\\loan_terms.txt");
            frObjectTerm   = new FileReader( fileObjectTerm );
            brObjectTerm = new BufferedReader( frObjectTerm );

        }catch(Exception Ex){

            System.out.println("\nAn Exception occured while creating a BufferedReader for " + FILE_TERM + ".\n" );
            Platform.exit();

        }

        try { //Try-catch for interest rate file.

            //Initialize interest rate file reading components.
            fileObjectInterest = new File("E:\\JavaFXPrograms\\homework5\\src\\annual_interest_rates.txt");
            frObjectInterest = new FileReader(fileObjectInterest);
            brObjectInterest = new BufferedReader(frObjectInterest);

        }catch(Exception ex) {

            System.out.println("\nAn Exception occured while creating a BufferedReader for " + FILE_INTEREST + ".\n");
            Platform.exit();

        }

        try { //Term file reading

            while ( (inputValue = brObjectTerm.readLine()) != null)
            {
                int term = Integer.parseInt(inputValue);
                termList.add(term);
            }

            while ( (inputValue = brObjectInterest.readLine()) != null) {
                double interestRate = Double.parseDouble(inputValue);
                interestRateList.add(interestRate);
            }

        }catch (IOException ex){

            System.out.println("\nAn IOException occured while reading the file..\n");

        }catch (Exception ex) {

            System.out.println("\nAn Exception occured while reading the file..\n");

        }
    }
}

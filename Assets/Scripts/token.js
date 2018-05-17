function OnMouseDown() {
    var token = PlayerPrefs.GetString("Token");
    var message = credit(token);
    if (token == '') {
        PlayerPrefs.SetString("Token", message);
    }
    else {
        if (message != 'ineligible') {
            PlayerPrefs.SetString("Credits", message);
            print(message);
        }
        if (message == 'ineligible') { PlayerPrefs.SetString("Error Display", "Only 1 Point Allowed Per Day");}
    }
}

function DisplayRedeem() {
    var token = PlayerPrefs.GetString("Token");
    var message = redeem(token);
    if (token == '') {
        PlayerPrefs.SetString("Token", message);
    }
    else {
        if (message.Substring(0,1) != 'i') {
            print(message.Substring(0,1));
            PlayerPrefs.SetString("Credits", message);
        } else {
            if (message == 'insufficient') {
                print('not enough points');
                PlayerPrefs.SetString("Error Display", "Not Enough Points");
            } else {
                print('you need to be patient!');
                PlayerPrefs.SetString("Error Display", "Redeem Points With Next Purchase");
            };
        }
    }
}

function credit(token) {
    var parameter = (token != '') ? '?credit=' + token : '';
    var url = "http://www.prociate.com/cdk/darbys.php" + parameter;
    var www = new WWW(url);
    while (!www.isDone);
    return www.text;

}

function redeem(token) {
    var parameter = (token != '') ? '?redeem=' + token : '';
    var url = "http://www.prociate.com/cdk/darbys.php" + parameter;
    var www = new WWW(url);
    while (!www.isDone);
    return www.text;

}
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using LaenderRaten.Lib.Services;
using System.Runtime.CompilerServices;

namespace LaenderRaten.Lib.Models;

public class UseCountries : ILoadRepository
{

    

    IRepository _sqlrepsitory = new SqliteRepository("C:\\Users\\thoma\\AppData\\Local\\Packages\\com.companyname.laenderraten.gui_9zz4h110yvjzm\\LocalState\\data.sqlite");
    IInputRepository _inputrepository;

    string _path = string.Empty;
    public UseCountries(string path)
    {
        _path = path;
    }

    public List<Land> LoadAll()
    {
        List<Land> lands = new List<Land>();

        Land c1 = new("Afghanistan", "Kabul", "afghanistan.png", "Asien");
        _sqlrepsitory.Add(c1);

        Land c2 = new("Albanien", "Tirana", "albanien.png", "Europa");
        _sqlrepsitory.Add(c2);

        Land c3 = new("Algerien", "Algier", "algerien.png", "Afrika");
        _sqlrepsitory.Add(c3);

        Land c4 = new("Andorra", "Andorra la Vella", "andorra.png", "Europa");
        _sqlrepsitory.Add(c4);

        Land c5 = new("Angola", "Luanda", "angola.png", "Afrika");
        _sqlrepsitory.Add(c5);

        Land c6 = new("Antigua und Barbuda", "Saint John’s", "antiguaundbarbuda.png", "Nordamerika");
        _sqlrepsitory.Add(c6);

        Land c7 = new("Argentinien", "Buenos Aires", "argentinien.png", "Suedamerika");
        _sqlrepsitory.Add(c7);

        Land c8 = new("Armenien", "Jerewan", "armenien.png", "Asien/Europa");
        _sqlrepsitory.Add(c8);

        Land c9 = new("Australien", "Canberra", "australien.png", "Australien");
        _sqlrepsitory.Add(c9);

        Land c10 = new("Oesterreich", "Wien", "oesterreich.png", "Europa");
        _sqlrepsitory.Add(c10);

        Land c11 = new("Aserbaidschan", "Baku", "aserbaidschan.png", "Asien/Europa");
        _sqlrepsitory.Add(c11);

        Land c12 = new("Bahamas", "Nassau", "bahamas.png", "Nordamerika");
        _sqlrepsitory.Add(c12);

        Land c13 = new("Bahrain", "Manama", "bahrain.png", "Asien");
        _sqlrepsitory.Add(c13);

        Land c14 = new("Bangladesch", "Dhaka", "bangladesch.png", "Asien");
        _sqlrepsitory.Add(c14);

        Land c15 = new("Barbados", "Bridgetown", "barbados.png", "Nordamerika");
        _sqlrepsitory.Add(c15);

        Land c16 = new("Weissrussland", "Minsk", "weissrussland.png", "Europa");
        _sqlrepsitory.Add(c16);

        Land c17 = new("Belgien", "Bruessel", "belgien.png", "Europa");
        _sqlrepsitory.Add(c17);

        Land c18 = new("Belize", "Belmopan", "belize.png", "Nordamerika");
        _sqlrepsitory.Add(c18);

        Land c19 = new("Benin", "Porto-Novo", "benin.png", "Afrika");
        _sqlrepsitory.Add(c19);

        Land c20 = new("Bhutan", "Thimphu", "bhutan.png", "Asien");
        _sqlrepsitory.Add(c20);

        Land c21 = new("Bolivien", "Sucre", "bolivien.png", "Suedamerika");
        _sqlrepsitory.Add(c21);

        Land c22 = new("Bosnien und Herzegowina", "Sarajevo", "bosnienundherzegowina.png", "Europa");
        _sqlrepsitory.Add(c22);

        Land c23 = new("Botswana", "Gaborone", "botswana.png", "Afrika");
        _sqlrepsitory.Add(c23);

        Land c24 = new("Brasilien", "Brasília", "brasilien.png", "Suedamerika");
        _sqlrepsitory.Add(c24);

        Land c25 = new("Brunei", "Bandar Seri Begawan", "brunei.png", "Asien");
        _sqlrepsitory.Add(c25);

        Land c26 = new("Bulgarien", "Sofia", "bulgarien.png", "Europa");
        _sqlrepsitory.Add(c26);

        Land c27 = new("Burkina Faso", "Ouagadougou", "burkinafaso.png", "Afrika");
        _sqlrepsitory.Add(c27);

        Land c28 = new("Burundi", "Bujumbura", "burundi.png", "Afrika");
        _sqlrepsitory.Add(c28);

        Land c29 = new("Kap Verde", "Praia", "kapverde.png", "Afrika");
        _sqlrepsitory.Add(c29);

        Land c30 = new("Kambodscha", "Phnom Penh", "kambodscha.png", "Asien");
        _sqlrepsitory.Add(c30);

        Land c31 = new("Kamerun", "Yaoundé", "kamerun.png", "Afrika");
        _sqlrepsitory.Add(c31);

        Land c32 = new("Kanada", "Ottawa", "kanada.png", "Nordamerika");
        _sqlrepsitory.Add(c32);

        Land c33 = new("Zentralafrikanische Republik", "Bangui", "zentralafrikanischerepublik.png", "Afrika");
        _sqlrepsitory.Add(c33);

        Land c34 = new("Tschad", "N’Djamena", "tschad.png", "Afrika");
        _sqlrepsitory.Add(c34);

        Land c35 = new("Chile", "Santiago de Chile", "chile.png", "Suedamerika");
        _sqlrepsitory.Add(c35);

        Land c36 = new("China", "Peking", "china.png", "Asien");
        _sqlrepsitory.Add(c36);

        Land c37 = new("Kolumbien", "Bogotá", "kolumbien.png", "Suedamerika");
        _sqlrepsitory.Add(c37);

        Land c38 = new("Komoren", "Moroni", "komoren.png", "Afrika");
        _sqlrepsitory.Add(c38);

        Land c39 = new("Kongo, Demokratische Republik", "Kinshasa", "kongodemokratischerepublik.png", "Afrika");
        _sqlrepsitory.Add(c39);

        Land c40 = new("Kongo, Republik", "Brazzaville", "kongorepublik.png", "Afrika");
        _sqlrepsitory.Add(c40);

        Land c41 = new("Costa Rica", "San José", "costarica.png", "Nordamerika");
        _sqlrepsitory.Add(c41);

        Land c42 = new("Elfenbeinküste", "Yamoussoukro", "elfenbeinkueste.png", "Afrika");
        _sqlrepsitory.Add(c42);

        Land c43 = new("Kroatien", "Zagreb", "kroatien.png", "Europa");
        _sqlrepsitory.Add(c43);

        Land c44 = new("Kuba", "Havanna", "kuba.png", "Nordamerika");
        _sqlrepsitory.Add(c44);

        Land c45 = new("Zypern", "Nikosia", "zypern.png", "Europa/Asien");
        _sqlrepsitory.Add(c45);

        Land c46 = new("Tschechien", "Prag", "tschechien.png", "Europa");
        _sqlrepsitory.Add(c46);

        Land c47 = new("Dänemark", "Kopenhagen", "daenemark.png", "Europa");
        _sqlrepsitory.Add(c47);

        Land c48 = new("Dschibuti", "Dschibuti", "dschibuti.png", "Afrika");
        _sqlrepsitory.Add(c48);

        Land c49 = new("Dominica", "Roseau", "dominica.png", "Nordamerika");
        _sqlrepsitory.Add(c49);

        Land c50 = new("Dominikanische Republik", "Santo Domingo", "dominikanischerepublik.png", "Nordamerika");
        _sqlrepsitory.Add(c50);

        Land c51 = new("Ecuador", "Quito", "ecuador.png", "Suedamerika");
        _sqlrepsitory.Add(c51);

        Land c52 = new("Ägypten", "Kairo", "aegypten.png", "Afrika");
        _sqlrepsitory.Add(c52);

        Land c53 = new("El Salvador", "San Salvador", "elsalvador.png", "Nordamerika");
        _sqlrepsitory.Add(c53);

        Land c54 = new("Äquatorialguinea", "Malabo", "aequatorialguinea.png", "Afrika");
        _sqlrepsitory.Add(c54);

        Land c55 = new("Eritrea", "Asmara", "eritrea.png", "Afrika");
        _sqlrepsitory.Add(c55);

        Land c56 = new("Estland", "Tallinn", "estland.png", "Europa");
        _sqlrepsitory.Add(c56);

        Land c57 = new("Eswatini", "Mbabane", "eswatini.png", "Afrika");
        _sqlrepsitory.Add(c57);

        Land c58 = new("Äthiopien", "Addis Abeba", "aethiopien.png", "Afrika");
        _sqlrepsitory.Add(c58);

        Land c59 = new("Fidschi", "Suva", "fidschi.png", "Australien");
        _sqlrepsitory.Add(c59);

        Land c60 = new("Finnland", "Helsinki", "finnland.png", "Europa");
        _sqlrepsitory.Add(c60);

        Land c61 = new("Frankreich", "Paris", "frankreich.png", "Europa");
        _sqlrepsitory.Add(c61);

        Land c62 = new("Gabun", "Libreville", "gabun.png", "Afrika");
        _sqlrepsitory.Add(c62);

        Land c63 = new("Gambia", "Banjul", "gambia.png", "Afrika");
        _sqlrepsitory.Add(c63);

        Land c64 = new("Georgien", "Tiflis", "georgien.png", "Europa/Asien");
        _sqlrepsitory.Add(c64);

        Land c65 = new("Deutschland", "Berlin", "deutschland.png", "Europa");
        _sqlrepsitory.Add(c65);

        Land c66 = new("Ghana", "Accra", "ghana.png", "Afrika");
        _sqlrepsitory.Add(c66);

        Land c67 = new("Griechenland", "Athen", "griechenland.png", "Europa");
        _sqlrepsitory.Add(c67);

        Land c68 = new("Grenada", "Saint George’s", "grenada.png", "Nordamerika");
        _sqlrepsitory.Add(c68);

        Land c69 = new("Guatemala", "Guatemala-Stadt", "guatemala.png", "Nordamerika");
        _sqlrepsitory.Add(c69);

        Land c70 = new("Guinea", "Conakry", "guinea.png", "Afrika");
        _sqlrepsitory.Add(c70);

        Land c71 = new("Guinea-Bissau", "Bissau", "guineabissau.png", "Afrika");
        _sqlrepsitory.Add(c71);

        Land c72 = new("Guyana", "Georgetown", "guyana.png", "Suedamerika");
        _sqlrepsitory.Add(c72);

        Land c73 = new("Haiti", "Port-au-Prince", "haiti.png", "Nordamerika");
        _sqlrepsitory.Add(c73);

        Land c74 = new("Honduras", "Tegucigalpa", "honduras.png", "Nordamerika");
        _sqlrepsitory.Add(c74);

        Land c75 = new("Ungarn", "Budapest", "ungarn.png", "Europa");
        _sqlrepsitory.Add(c75);

        Land c76 = new("Island", "Reykjavík", "island.png", "Europa");
        _sqlrepsitory.Add(c76);

        Land c77 = new("Indien", "Neu-Delhi", "indien.png", "Asien");
        _sqlrepsitory.Add(c77);

        Land c78 = new("Indonesien", "Jakarta", "indonesien.png", "Asien");
        _sqlrepsitory.Add(c78);

        Land c79 = new("Iran", "Teheran", "iran.png", "Asien");
        _sqlrepsitory.Add(c79);

        Land c80 = new("Irak", "Bagdad", "irak.png", "Asien");
        _sqlrepsitory.Add(c80);

        Land c81 = new("Irland", "Dublin", "irland.png", "Europa");
        _sqlrepsitory.Add(c81);

        Land c82 = new("Israel", "Jerusalem", "israel.png", "Asien");
        _sqlrepsitory.Add(c82);

        Land c83 = new("Italien", "Rom", "italien.png", "Europa");
        _sqlrepsitory.Add(c83);

        Land c84 = new("Jamaika", "Kingston", "jamaika.png", "Nordamerika");
        _sqlrepsitory.Add(c84);

        Land c85 = new("Japan", "Tokio", "japan.png", "Asien");
        _sqlrepsitory.Add(c85);

        Land c86 = new("Jordanien", "Amman", "jordanien.png", "Asien");
        _sqlrepsitory.Add(c86);

        Land c87 = new("Kasachstan", "Astana", "kasachstan.png", "Asien/Europa");
        _sqlrepsitory.Add(c87);

        Land c88 = new("Kenia", "Nairobi", "kenia.png", "Afrika");
        _sqlrepsitory.Add(c88);

        Land c89 = new("Kiribati", "Tarawa", "kiribati.png", "Australien");
        _sqlrepsitory.Add(c89);

        Land c90 = new("Nordkorea", "Pjöngjang", "nordkorea.png", "Asien");
        _sqlrepsitory.Add(c90);

        Land c91 = new("Südkorea", "Seoul", "suedkorea.png", "Asien");
        _sqlrepsitory.Add(c91);

        Land c92 = new("Kuwait", "Kuwait-Stadt", "kuwait.png", "Asien");
        _sqlrepsitory.Add(c92);

        Land c93 = new("Kirgisistan", "Bischkek", "kirgisistan.png", "Asien");
        _sqlrepsitory.Add(c93);

        Land c94 = new("Laos", "Vientiane", "laos.png", "Asien");
        _sqlrepsitory.Add(c94);

        Land c95 = new("Lettland", "Riga", "lettland.png", "Europa");
        _sqlrepsitory.Add(c95);

        Land c96 = new("Libanon", "Beirut", "libanon.png", "Asien");
        _sqlrepsitory.Add(c96);

        Land c97 = new("Lesotho", "Maseru", "lesotho.png", "Afrika");
        _sqlrepsitory.Add(c97);

        Land c98 = new("Liberia", "Monrovia", "liberia.png", "Afrika");
        _sqlrepsitory.Add(c98);

        Land c99 = new("Libyen", "Tripolis", "libyen.png", "Afrika");
        _sqlrepsitory.Add(c99);

        Land c100 = new("Liechtenstein", "Vaduz", "liechtenstein.png", "Europa");
        _sqlrepsitory.Add(c100);

        Land c101 = new("Litauen", "Vilnius", "litauen.png", "Europa");
        _sqlrepsitory.Add(c101);

        Land c102 = new("Luxemburg", "Luxemburg", "luxemburg.png", "Europa");
        _sqlrepsitory.Add(c102);

        Land c103 = new("Madagaskar", "Antananarivo", "madagaskar.png", "Afrika");
        _sqlrepsitory.Add(c103);

        Land c104 = new("Malawi", "Lilongwe", "malawi.png", "Afrika");
        _sqlrepsitory.Add(c104);

        Land c105 = new("Malaysia", "Kuala Lumpur", "malaysia.png", "Asien");
        _sqlrepsitory.Add(c105);

        Land c106 = new("Malediven", "Malé", "malediven.png", "Asien");
        _sqlrepsitory.Add(c106);

        Land c107 = new("Mali", "Bamako", "mali.png", "Afrika");
        _sqlrepsitory.Add(c107);

        Land c108 = new("Malta", "Valletta", "malta.png", "Europa");
        _sqlrepsitory.Add(c108);

        Land c109 = new("Marshallinseln", "Majuro", "marshallinseln.png", "Australien");
        _sqlrepsitory.Add(c109);

        Land c110 = new("Mauretanien", "Nouakchott", "mauretanien.png", "Afrika");
        _sqlrepsitory.Add(c110);

        Land c111 = new("Mauritius", "Port Louis", "mauritius.png", "Afrika");
        _sqlrepsitory.Add(c111);

        Land c112 = new("Mexiko", "Mexiko-Stadt", "mexiko.png", "Nordamerika");
        _sqlrepsitory.Add(c112);

        Land c113 = new("Mikronesien", "Palikir", "mikronesien.png", "Australien");
        _sqlrepsitory.Add(c113);

        Land c114 = new("Moldau", "Chișinău", "moldau.png", "Europa");
        _sqlrepsitory.Add(c114);

        Land c115 = new("Monaco", "Monaco", "monaco.png", "Europa");
        _sqlrepsitory.Add(c115);

        Land c116 = new("Mongolei", "Ulaanbaatar", "mongolei.png", "Asien");
        _sqlrepsitory.Add(c116);

        Land c117 = new("Montenegro", "Podgorica", "montenegro.png", "Europa");
        _sqlrepsitory.Add(c117);

        Land c118 = new("Marokko", "Rabat", "marokko.png", "Afrika");
        _sqlrepsitory.Add(c118);

        Land c119 = new("Mosambik", "Maputo", "mosambik.png", "Afrika");
        _sqlrepsitory.Add(c119);

        Land c120 = new("Myanmar", "Naypyidaw", "myanmar.png", "Asien");
        _sqlrepsitory.Add(c120);

        Land c121 = new("Namibia", "Windhoek", "namibia.png", "Afrika");
        _sqlrepsitory.Add(c121);

        Land c122 = new("Nauru", "Yaren", "nauru.png", "Australien");
        _sqlrepsitory.Add(c122);

        Land c123 = new("Nepal", "Kathmandu", "nepal.png", "Asien");
        _sqlrepsitory.Add(c123);

        Land c124 = new("Niederlande", "Amsterdam", "niederlande.png", "Europa");
        _sqlrepsitory.Add(c124);

        Land c125 = new("Neuseeland", "Wellington", "neuseeland.png", "Australien");
        _sqlrepsitory.Add(c125);

        Land c126 = new("Nicaragua", "Managua", "nicaragua.png", "Nordamerika");
        _sqlrepsitory.Add(c126);

        Land c127 = new("Niger", "Niamey", "niger.png", "Afrika");
        _sqlrepsitory.Add(c127);

        Land c128 = new("Nigeria", "Abuja", "nigeria.png", "Afrika");
        _sqlrepsitory.Add(c128);

        Land c129 = new("Nordmazedonien", "Skopje", "nordmazedonien.png", "Europa");
        _sqlrepsitory.Add(c129);

        Land c130 = new("Norwegen", "Oslo", "norwegen.png", "Europa");
        _sqlrepsitory.Add(c130);

        Land c131 = new("Oman", "Maskat", "oman.png", "Asien");
        _sqlrepsitory.Add(c131);

        Land c132 = new("Pakistan", "Islamabad", "pakistan.png", "Asien");
        _sqlrepsitory.Add(c132);

        Land c133 = new("Palau", "Ngerulmud", "palau.png", "Australien");
        _sqlrepsitory.Add(c133);

        Land c134 = new("Palästina", "Ramallah", "palaestina.png", "Asien");
        _sqlrepsitory.Add(c134);

        Land c135 = new("Panama", "Panama-Stadt", "panama.png", "Nordamerika");
        _sqlrepsitory.Add(c135);

        Land c136 = new("Papua-Neuguinea", "Port Moresby", "papuaneuguinea.png", "Australien");
        _sqlrepsitory.Add(c136);

        Land c137 = new("Paraguay", "Asunción", "paraguay.png", "Suedamerika");
        _sqlrepsitory.Add(c137);

        Land c138 = new("Peru", "Lima", "peru.png", "Suedamerika");
        _sqlrepsitory.Add(c138);

        Land c139 = new("Philippinen", "Manila", "philippinen.png", "Asien");
        _sqlrepsitory.Add(c139);

        Land c140 = new("Polen", "Warschau", "polen.png", "Europa");
        _sqlrepsitory.Add(c140);

        Land c141 = new("Portugal", "Lissabon", "portugal.png", "Europa");
        _sqlrepsitory.Add(c141);

        Land c142 = new("Katar", "Doha", "katar.png", "Asien");
        _sqlrepsitory.Add(c142);

        Land c143 = new("Rumänien", "Bukarest", "rumaenien.png", "Europa");
        _sqlrepsitory.Add(c143);

        Land c144 = new("Russland", "Moskau", "russland.png", "Europa/Asien");
        _sqlrepsitory.Add(c144);

        Land c145 = new("Ruanda", "Kigali", "ruanda.png", "Afrika");
        _sqlrepsitory.Add(c145);

        Land c146 = new("St. Kitts und Nevis", "Basseterre", "stkittsundnevis.png", "Nordamerika");
        _sqlrepsitory.Add(c146);

        Land c147 = new("St. Lucia", "Castries", "stlucia.png", "Nordamerika");
        _sqlrepsitory.Add(c147);

        Land c148 = new("St. Vincent und die Grenadinen", "Kingstown", "stvincentunddiegrenadinen.png", "Nordamerika");
        _sqlrepsitory.Add(c148);

        Land c149 = new("Samoa", "Apia", "samoa.png", "Australien");
        _sqlrepsitory.Add(c149);

        Land c150 = new("San Marino", "San Marino", "sanmarino.png", "Europa");
        _sqlrepsitory.Add(c150);

        Land c151 = new("Sao Tome und Principe", "São Tomé", "saotomeundprincipe.png", "Afrika");
        _sqlrepsitory.Add(c151);

        Land c152 = new("Saudi-Arabien", "Riad", "saudiarabien.png", "Asien");
        _sqlrepsitory.Add(c152);

        Land c153 = new("Senegal", "Dakar", "senegal.png", "Afrika");
        _sqlrepsitory.Add(c153);

        Land c154 = new("Serbien", "Belgrad", "serbien.png", "Europa");
        _sqlrepsitory.Add(c154);

        Land c155 = new("Seychellen", "Victoria", "seychellen.png", "Afrika");
        _sqlrepsitory.Add(c155);

        Land c156 = new("Sierra Leone", "Freetown", "sierraleone.png", "Afrika");
        _sqlrepsitory.Add(c156);

        Land c157 = new("Singapur", "Singapur", "singapur.png", "Asien");
        _sqlrepsitory.Add(c157);

        Land c158 = new("Slowakei", "Bratislava", "slowakei.png", "Europa");
        _sqlrepsitory.Add(c158);

        Land c159 = new("Slowenien", "Ljubljana", "slowenien.png", "Europa");
        _sqlrepsitory.Add(c159);

        Land c160 = new("Salomonen", "Honiara", "salomonen.png", "Australien");
        _sqlrepsitory.Add(c160);

        Land c161 = new("Somalia", "Mogadischu", "somalia.png", "Afrika");
        _sqlrepsitory.Add(c161);

        Land c162 = new("Südafrika", "Pretoria", "suedafrika.png", "Afrika");
        _sqlrepsitory.Add(c162);

        Land c163 = new("Südsudan", "Juba", "suedsudan.png", "Afrika");
        _sqlrepsitory.Add(c163);

        Land c164 = new("Spanien", "Madrid", "spanien.png", "Europa");
        _sqlrepsitory.Add(c164);

        Land c165 = new("Sri Lanka", "Colombo", "srilanka.png", "Asien");
        _sqlrepsitory.Add(c165);

        Land c166 = new("Sudan", "Khartum", "sudan.png", "Afrika");
        _sqlrepsitory.Add(c166);

        Land c167 = new("Suriname", "Paramaribo", "suriname.png", "Suedamerika");
        _sqlrepsitory.Add(c167);

        Land c168 = new("Schweden", "Stockholm", "schweden.png", "Europa");
        _sqlrepsitory.Add(c168);

        Land c169 = new("Schweiz", "Bern", "schweiz.png", "Europa");
        _sqlrepsitory.Add(c169);

        Land c170 = new("Syrien", "Damaskus", "syrien.png", "Asien");
        _sqlrepsitory.Add(c170);

        Land c171 = new("Tadschikistan", "Duschanbe", "tadschikistan.png", "Asien");
        _sqlrepsitory.Add(c171);

        Land c172 = new("Tansania", "Dodoma", "tansania.png", "Afrika");
        _sqlrepsitory.Add(c172);

        Land c173 = new("Thailand", "Bangkok", "thailand.png", "Asien");
        _sqlrepsitory.Add(c173);

        Land c174 = new("Timor-Leste", "Dili", "timorleste.png", "Asien");
        _sqlrepsitory.Add(c174);

        Land c175 = new("Togo", "Lomé", "togo.png", "Afrika");
        _sqlrepsitory.Add(c175);

        Land c176 = new("Tonga", "Nukuʻalofa", "tonga.png", "Australien");
        _sqlrepsitory.Add(c176);

        Land c177 = new("Trinidad und Tobago", "Port of Spain", "trinidadundtobago.png", "Nordamerika");
        _sqlrepsitory.Add(c177);

        Land c178 = new("Tunesien", "Tunis", "tunesien.png", "Afrika");
        _sqlrepsitory.Add(c178);

        Land c179 = new("Türkei", "Ankara", "tuerkei.png", "Asien/Europa");
        _sqlrepsitory.Add(c179);

        Land c180 = new("Turkmenistan", "Aschgabat", "turkmenistan.png", "Asien");
        _sqlrepsitory.Add(c180);

        Land c181 = new("Tuvalu", "Funafuti", "tuvalu.png", "Australien");
        _sqlrepsitory.Add(c181);

        Land c182 = new("Uganda", "Kampala", "uganda.png", "Afrika");
        _sqlrepsitory.Add(c182);

        Land c183 = new("Ukraine", "Kiew", "ukraine.png", "Europa");
        _sqlrepsitory.Add(c183);

        Land c184 = new("Vereinigte Arabische Emirate", "Abu Dhabi", "vereinigtearabischeemirate.png", "Asien");
        _sqlrepsitory.Add(c184);

        Land c185 = new("Vereinigtes Königreich", "London", "vereinigteskoenigreich.png", "Europa");
        _sqlrepsitory.Add(c185);

        Land c186 = new("USA", "Washington, D.C.", "usa.png", "Nordamerika");
        _sqlrepsitory.Add(c186);

        Land c187 = new("Uruguay", "Montevideo", "uruguay.png", "Suedamerika");
        _sqlrepsitory.Add(c187);

        Land c188 = new("Usbekistan", "Taschkent", "usbekistan.png", "Asien");
        _sqlrepsitory.Add(c188);

        Land c189 = new("Vanuatu", "Port Vila", "vanuatu.png", "Australien");
        _sqlrepsitory.Add(c189);

        Land c190 = new("Vatikanstadt", "Vatikanstadt", "vatikanstadt.png", "Europa");
        _sqlrepsitory.Add(c190);

        Land c191 = new("Venezuela", "Caracas", "venezuela.png", "Suedamerika");
        _sqlrepsitory.Add(c191);

        Land c192 = new("Vietnam", "Hanoi", "vietnam.png", "Asien");
        _sqlrepsitory.Add(c192);

        Land c193 = new("Jemen", "Sanaa", "jemen.png", "Asien");
        _sqlrepsitory.Add(c193);

        Land c194 = new("Sambia", "Lusaka", "sambia.png", "Afrika");
        _sqlrepsitory.Add(c194);

        Land c195 = new("Simbabwe", "Harare", "simbabwe.png", "Afrika");
        _sqlrepsitory.Add(c195);

        var countries = _sqlrepsitory.GetAll();

        foreach (var country in countries)
        {
            lands.Add(country);
        }

        return lands;
        
    }
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace LeitorNfe.Models
{
    [XmlRoot(ElementName="ide")]
    public class Ide { 

        [XmlElement(ElementName="cUF")] 
        public int CUF { get; set; } 

        [XmlElement(ElementName="cNF")] 
        public int CNF { get; set; } 

        [XmlElement(ElementName="natOp")] 
        public required string NatOp { get; set; } 

        [XmlElement(ElementName="mod")] 
        public int Mod { get; set; } 

        [XmlElement(ElementName="serie")] 
        public int Serie { get; set; } 

        [XmlElement(ElementName="nNF")] 
        public int NNF { get; set; } 

        [XmlElement(ElementName="dhEmi")] 
        public DateTime DhEmi { get; set; } 

        [XmlElement(ElementName="dhSaiEnt")] 
        public DateTime DhSaiEnt { get; set; } 

        [XmlElement(ElementName="tpNF")] 
        public int TpNF { get; set; } 

        [XmlElement(ElementName="idDest")] 
        public int IdDest { get; set; } 

        [XmlElement(ElementName="cMunFG")] 
        public int CMunFG { get; set; } 

        [XmlElement(ElementName="tpImp")] 
        public int TpImp { get; set; } 

        [XmlElement(ElementName="tpEmis")] 
        public int TpEmis { get; set; } 

        [XmlElement(ElementName="cDV")] 
        public int CDV { get; set; } 

        [XmlElement(ElementName="tpAmb")] 
        public int TpAmb { get; set; } 

        [XmlElement(ElementName="finNFe")] 
        public int FinNFe { get; set; } 

        [XmlElement(ElementName="indFinal")] 
        public int IndFinal { get; set; } 

        [XmlElement(ElementName="indPres")] 
        public int IndPres { get; set; } 

        [XmlElement(ElementName="procEmi")] 
        public int ProcEmi { get; set; } 

        [XmlElement(ElementName="verProc")] 
        public required string VerProc { get; set; } 
    }

    [XmlRoot(ElementName="enderEmit")]
    public class EnderEmit { 

        [XmlElement(ElementName="xLgr")] 
        public required string XLgr { get; set; } 

        [XmlElement(ElementName="nro")] 
        public required string Nro { get; set; } 

        [XmlElement(ElementName="xBairro")] 
        public required string XBairro { get; set; } 

        [XmlElement(ElementName="cMun")] 
        public int CMun { get; set; } 

        [XmlElement(ElementName="xMun")] 
        public required string XMun { get; set; } 

        [XmlElement(ElementName="UF")] 
        public required string UF { get; set; } 

        [XmlElement(ElementName="CEP")] 
        public int CEP { get; set; } 

        [XmlElement(ElementName="cPais")] 
        public int CPais { get; set; } 

        [XmlElement(ElementName="xPais")] 
        public required string XPais { get; set; } 

        [XmlElement(ElementName="fone")] 
        public double Fone { get; set; } 
    }

    [XmlRoot(ElementName="emit")]
    public class Emit { 

        [XmlElement(ElementName="CNPJ")] 
        public double CNPJ { get; set; } 

        [XmlElement(ElementName="xNome")] 
        public required string XNome { get; set; } 

        [XmlElement(ElementName="xFant")] 
        public required string XFant { get; set; } 

        [XmlElement(ElementName="enderEmit")] 
        public required EnderEmit EnderEmit { get; set; } 

        [XmlElement(ElementName="IE")] 
        public double IE { get; set; } 

        [XmlElement(ElementName="CRT")] 
        public int CRT { get; set; } 

        [XmlElement(ElementName="email")] 
        public string? Email { get; set; } 
    }

    [XmlRoot(ElementName="enderDest")]
    public class EnderDest { 

        [XmlElement(ElementName="xLgr")] 
        public required string XLgr { get; set; } 

        [XmlElement(ElementName="nro")] 
        public required string Nro { get; set; } 

        [XmlElement(ElementName="xCpl")] 
        public required string XCpl { get; set; } 

        [XmlElement(ElementName="xBairro")] 
        public required string XBairro { get; set; } 

        [XmlElement(ElementName="cMun")] 
        public int CMun { get; set; } 

        [XmlElement(ElementName="xMun")] 
        public required string XMun { get; set; } 

        [XmlElement(ElementName="UF")] 
        public required string UF { get; set; } 

        [XmlElement(ElementName="CEP")] 
        public int CEP { get; set; } 

        [XmlElement(ElementName="cPais")] 
        public int CPais { get; set; } 

        [XmlElement(ElementName="xPais")] 
        public required string XPais { get; set; } 

        [XmlElement(ElementName="fone")] 
        public double Fone { get; set; } 
    }

    [XmlRoot(ElementName="dest")]
    public class Dest { 

        [XmlElement(ElementName="CNPJ")] 
        public double? CNPJ { get; set; } 

        [XmlElement(ElementName="CPF")] 
        public double? CPF { get; set; } 

        [XmlElement(ElementName="xNome")] 
        public required string XNome { get; set; } 

        [XmlElement(ElementName="enderDest")] 
        public required EnderDest EnderDest { get; set; } 

        [XmlElement(ElementName="indIEDest")] 
        public int IndIEDest { get; set; } 

        [XmlElement(ElementName="IE")] 
        public double IE { get; set; } 

        [XmlElement(ElementName="email")] 
        public string? Email { get; set; } 
    }

    [XmlRoot(ElementName="prod")]
    public class Prod { 

        [XmlElement(ElementName="cProd")] 
        public required string CProd { get; set; } 

        [XmlElement(ElementName="cEAN")] 
        public required string CEAN { get; set; } 

        [XmlElement(ElementName="xProd")] 
        public required string XProd { get; set; } 

        [XmlElement(ElementName="NCM")] 
        public int NCM { get; set; } 

        [XmlElement(ElementName="CEST")] 
        public int CEST { get; set; } 

        [XmlElement(ElementName="CFOP")] 
        public int CFOP { get; set; } 

        [XmlElement(ElementName="uCom")] 
        public required string UCom { get; set; } 

        [XmlElement(ElementName="qCom")] 
        public double QCom { get; set; } 

        [XmlElement(ElementName="vUnCom")] 
        public double VUnCom { get; set; } 

        [XmlElement(ElementName="vProd")] 
        public double VProd { get; set; } 

        [XmlElement(ElementName="cEANTrib")] 
        public required string CEANTrib { get; set; } 

        [XmlElement(ElementName="uTrib")] 
        public required string UTrib { get; set; } 

        [XmlElement(ElementName="qTrib")] 
        public double QTrib { get; set; } 

        [XmlElement(ElementName="vUnTrib")] 
        public double VUnTrib { get; set; } 

        [XmlElement(ElementName="vDesc")] 
        public double VDesc { get; set; } 

        [XmlElement(ElementName="indTot")] 
        public int IndTot { get; set; } 
    }

    [XmlRoot(ElementName="ICMSSN102")]
    public class ICMSSN102 { 

        [XmlElement(ElementName="orig")] 
        public int Orig { get; set; } 

        [XmlElement(ElementName="CSOSN")] 
        public int CSOSN { get; set; } 
    }

    [XmlRoot(ElementName="ICMS")]
    public class ICMS { 

        [XmlElement(ElementName="ICMSSN102")] 
        public required ICMSSN102 ICMSSN102 { get; set; } 
    }

    [XmlRoot(ElementName="PISAliq")]
    public class PISAliq { 

        [XmlElement(ElementName="CST")] 
        public int CST { get; set; } 

        [XmlElement(ElementName="vBC")] 
        public double VBC { get; set; } 

        [XmlElement(ElementName="pPIS")] 
        public double PPIS { get; set; } 

        [XmlElement(ElementName="vPIS")] 
        public double VPIS { get; set; } 
    }

    [XmlRoot(ElementName="PIS")]
    public class PIS { 

        [XmlElement(ElementName="PISAliq")] 
        public required PISAliq PISAliq { get; set; } 
    }

    [XmlRoot(ElementName="COFINSAliq")]
    public class COFINSAliq { 

        [XmlElement(ElementName="CST")] 
        public int CST { get; set; } 

        [XmlElement(ElementName="vBC")] 
        public double VBC { get; set; } 

        [XmlElement(ElementName="pCOFINS")] 
        public double PCOFINS { get; set; } 

        [XmlElement(ElementName="vCOFINS")] 
        public double VCOFINS { get; set; } 
    }

    [XmlRoot(ElementName="COFINS")]
    public class COFINS { 

        [XmlElement(ElementName="COFINSAliq")] 
        public required COFINSAliq COFINSAliq { get; set; } 
    }

    [XmlRoot(ElementName="imposto")]
    public class Imposto { 

        [XmlElement(ElementName="vTotTrib")] 
        public double VTotTrib { get; set; } 

        [XmlElement(ElementName="ICMS")] 
        public required ICMS ICMS { get; set; } 

        [XmlElement(ElementName="PIS")] 
        public required PIS PIS { get; set; } 

        [XmlElement(ElementName="COFINS")] 
        public required COFINS COFINS { get; set; } 
    }

    [XmlRoot(ElementName="det")]
    public class Det { 

        [XmlElement(ElementName="prod")] 
        public required Prod Prod { get; set; } 

        [XmlElement(ElementName="imposto")] 
        public required Imposto Imposto { get; set; } 

        [XmlAttribute(AttributeName="nItem")] 
        public int NItem { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="ICMSTot")]
    public class ICMSTot { 

        [XmlElement(ElementName="vBC")] 
        public double VBC { get; set; } 

        [XmlElement(ElementName="vICMS")] 
        public double VICMS { get; set; } 

        [XmlElement(ElementName="vICMSDeson")] 
        public double VICMSDeson { get; set; } 

        [XmlElement(ElementName="vFCP")] 
        public double VFCP { get; set; } 

        [XmlElement(ElementName="vBCST")] 
        public double VBCST { get; set; } 

        [XmlElement(ElementName="vST")] 
        public double VST { get; set; } 

        [XmlElement(ElementName="vFCPST")] 
        public double VFCPST { get; set; } 

        [XmlElement(ElementName="vFCPSTRet")] 
        public double VFCPSTRet { get; set; } 

        [XmlElement(ElementName="vProd")] 
        public double VProd { get; set; } 

        [XmlElement(ElementName="vFrete")] 
        public double VFrete { get; set; } 

        [XmlElement(ElementName="vSeg")] 
        public double VSeg { get; set; } 

        [XmlElement(ElementName="vDesc")] 
        public double VDesc { get; set; } 

        [XmlElement(ElementName="vII")] 
        public double VII { get; set; } 

        [XmlElement(ElementName="vIPI")] 
        public double VIPI { get; set; } 

        [XmlElement(ElementName="vIPIDevol")] 
        public double VIPIDevol { get; set; } 

        [XmlElement(ElementName="vPIS")] 
        public double VPIS { get; set; } 

        [XmlElement(ElementName="vCOFINS")] 
        public double VCOFINS { get; set; } 

        [XmlElement(ElementName="vOutro")] 
        public double VOutro { get; set; } 

        [XmlElement(ElementName="vNF")] 
        public double VNF { get; set; } 

        [XmlElement(ElementName="vTotTrib")] 
        public double VTotTrib { get; set; } 
    }

    [XmlRoot(ElementName="total")]
    public class Total { 

        [XmlElement(ElementName="ICMSTot")] 
        public required ICMSTot ICMSTot { get; set; } 
    }

    [XmlRoot(ElementName="transp")]
    public class Transp { 

        [XmlElement(ElementName="modFrete")] 
        public int ModFrete { get; set; } 

        [XmlElement(ElementName="vol")] 
        public required object Vol { get; set; } 
    }

    [XmlRoot(ElementName="fat")]
    public class Fat { 

        [XmlElement(ElementName="nFat")] 
        public int NFat { get; set; } 

        [XmlElement(ElementName="vOrig")] 
        public double VOrig { get; set; } 

        [XmlElement(ElementName="vDesc")] 
        public double VDesc { get; set; } 

        [XmlElement(ElementName="vLiq")] 
        public double VLiq { get; set; } 
    }

    [XmlRoot(ElementName="dup")]
    public class Dup { 

        [XmlElement(ElementName="nDup")] 
        public int NDup { get; set; } 

        [XmlElement(ElementName="dVenc")] 
        public DateTime DVenc { get; set; } 

        [XmlElement(ElementName="vDup")] 
        public double VDup { get; set; } 
    }

    [XmlRoot(ElementName="cobr")]
    public class Cobr { 

        [XmlElement(ElementName="fat")] 
        public required Fat Fat { get; set; } 

        [XmlElement(ElementName="dup")] 
        public required List<Dup> Dup { get; set; } 
    }

    [XmlRoot(ElementName="detPag")]
    public class DetPag { 

        [XmlElement(ElementName="tPag")] 
        public int TPag { get; set; } 

        [XmlElement(ElementName="vPag")] 
        public double VPag { get; set; } 
    }

    [XmlRoot(ElementName="pag")]
    public class Pag { 

        [XmlElement(ElementName="detPag")] 
        public required DetPag DetPag { get; set; } 
    }

    [XmlRoot(ElementName="infRespTec")]
    public class InfRespTec { 

        [XmlElement(ElementName="CNPJ")] 
        public double CNPJ { get; set; } 

        [XmlElement(ElementName="xContato")] 
        public required string XContato { get; set; } 

        [XmlElement(ElementName="email")] 
        public required string Email { get; set; } 

        [XmlElement(ElementName="fone")] 
        public double Fone { get; set; } 
    }

    [XmlRoot(ElementName="infNFe")]
    public class InfNFe { 

        [XmlElement(ElementName="ide")] 
        public required Ide Ide { get; set; } 

        [XmlElement(ElementName="emit")] 
        public required Emit Emit { get; set; } 

        [XmlElement(ElementName="dest")] 
        public required Dest Dest { get; set; } 

        [XmlElement(ElementName="det")] 
        public required List<Det> Det { get; set; } 

        [XmlElement(ElementName="total")] 
        public required Total Total { get; set; } 

        [XmlElement(ElementName="transp")] 
        public required Transp Transp { get; set; } 

        [XmlElement(ElementName="cobr")] 
        public required Cobr Cobr { get; set; } 

        [XmlElement(ElementName="pag")] 
        public required Pag Pag { get; set; } 

        [XmlElement(ElementName="infRespTec")] 
        public required InfRespTec InfRespTec { get; set; } 

        [XmlAttribute(AttributeName="versao")] 
        public double Versao { get; set; } 

        [XmlAttribute(AttributeName="Id")] 
        public required string Id { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="CanonicalizationMethod")]
    public class CanonicalizationMethod { 

        [XmlAttribute(AttributeName="Algorithm")] 
        public required string Algorithm { get; set; } 
    }

    [XmlRoot(ElementName="SignatureMethod")]
    public class SignatureMethod { 

        [XmlAttribute(AttributeName="Algorithm")] 
        public required string Algorithm { get; set; } 
    }

    [XmlRoot(ElementName="Transform")]
    public class Transform { 

        [XmlAttribute(AttributeName="Algorithm")] 
        public required string Algorithm { get; set; } 
    }

    [XmlRoot(ElementName="Transforms")]
    public class Transforms { 

        [XmlElement(ElementName="Transform")] 
        public required List<Transform> Transform { get; set; } 
    }

    [XmlRoot(ElementName="DigestMethod")]
    public class DigestMethod { 

        [XmlAttribute(AttributeName="Algorithm")] 
        public required string Algorithm { get; set; } 
    }

    [XmlRoot(ElementName="Reference")]
    public class Reference { 

        [XmlElement(ElementName="Transforms")] 
        public required Transforms Transforms { get; set; } 

        [XmlElement(ElementName="DigestMethod")] 
        public required DigestMethod DigestMethod { get; set; } 

        [XmlElement(ElementName="DigestValue")] 
        public required string DigestValue { get; set; } 

        [XmlAttribute(AttributeName="URI")] 
        public required string URI { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="SignedInfo")]
    public class SignedInfo { 

        [XmlElement(ElementName="CanonicalizationMethod")] 
        public required CanonicalizationMethod CanonicalizationMethod { get; set; } 

        [XmlElement(ElementName="SignatureMethod")] 
        public required SignatureMethod SignatureMethod { get; set; } 

        [XmlElement(ElementName="Reference")] 
        public required Reference Reference { get; set; } 
    }

    [XmlRoot(ElementName="X509Data")]
    public class X509Data { 

        [XmlElement(ElementName="X509Certificate")] 
        public required string X509Certificate { get; set; } 
    }

    [XmlRoot(ElementName="KeyInfo")]
    public class KeyInfo { 

        [XmlElement(ElementName="X509Data")] 
        public required X509Data X509Data { get; set; } 
    }

    [XmlRoot(ElementName="Signature")]
    public class Signature { 

        [XmlElement(ElementName="SignedInfo")] 
        public required SignedInfo SignedInfo { get; set; } 

        [XmlElement(ElementName="SignatureValue")] 
        public required string SignatureValue { get; set; } 

        [XmlElement(ElementName="KeyInfo")] 
        public required KeyInfo KeyInfo { get; set; } 

        [XmlAttribute(AttributeName="xmlns")] 
        public required string Xmlns { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="NFe")]
    public class NFe { 

        [XmlElement(ElementName="infNFe")] 
        public required InfNFe InfNFe { get; set; } 

        [XmlElement(ElementName="Signature")] 
        public required Signature Signature { get; set; } 

        [XmlAttribute(AttributeName="xmlns")] 
        public required string Xmlns { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="infProt")]
    public class InfProt { 

        [XmlElement(ElementName="tpAmb")] 
        public int TpAmb { get; set; } 

        [XmlElement(ElementName="verAplic")] 
        public required string VerAplic { get; set; } 

        [XmlElement(ElementName="chNFe")] 
        public double ChNFe { get; set; } 

        [XmlElement(ElementName="dhRecbto")] 
        public DateTime DhRecbto { get; set; } 

        [XmlElement(ElementName="nProt")] 
        public double NProt { get; set; } 

        [XmlElement(ElementName="digVal")] 
        public required string DigVal { get; set; } 

        [XmlElement(ElementName="cStat")] 
        public int CStat { get; set; } 

        [XmlElement(ElementName="xMotivo")] 
        public required string XMotivo { get; set; } 

        [XmlAttribute(AttributeName="Id")] 
        public required string Id { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="protNFe")]
    public class ProtNFe { 

        [XmlElement(ElementName="infProt")] 
        public required InfProt InfProt { get; set; } 

        [XmlAttribute(AttributeName="versao")] 
        public double Versao { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }

    [XmlRoot(ElementName="nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [Serializable()]
    public class NfeProc { 

        [XmlElement(ElementName="NFe")] 
        public required NFe NFe { get; set; } 

        [XmlElement(ElementName="protNFe")] 
        public required ProtNFe ProtNFe { get; set; } 

        [XmlAttribute(AttributeName="versao")] 
        public double Versao { get; set; } 

        [XmlAttribute(AttributeName="xmlns")] 
        public required string Xmlns { get; set; } 

        [XmlText] 
        public required string Text { get; set; } 
    }


}

namespace DataRowTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CreateFremdschadenAbrechnungStrategyTest
    {
        [DataTestMethod]
        [DataRow(1, BuchungsVorgangArt.Bankbuchung, BewegungsGruppeType.EG, FremdSchadenAbrechnungArtType.Eingang)]
        [DataRow(2, BuchungsVorgangArt.Bankbuchung, BewegungsGruppeType.EG, FremdSchadenAbrechnungArtType.Eingang)]
        [DataRow(1, BuchungsVorgangArt.Bankbuchung, BewegungsGruppeType.AG, FremdSchadenAbrechnungArtType.Ausgang)]
        [DataRow(2, BuchungsVorgangArt.Bankbuchung, BewegungsGruppeType.AG, FremdSchadenAbrechnungArtType.Ausgang)]
        [DataRow(3, BuchungsVorgangArt.Umbuchung, default, FremdSchadenAbrechnungArtType.Umbuchung)]
        [DataRow(4, BuchungsVorgangArt.Umbuchung, default, FremdSchadenAbrechnungArtType.Umbuchung)]
        [DataRow(5, BuchungsVorgangArt.Ausbuchung, default, FremdSchadenAbrechnungArtType.Kosten)]
        [DataRow(6, BuchungsVorgangArt.Ausbuchung, default, FremdSchadenAbrechnungArtType.Kosten)]
        [DataRow(7, BuchungsVorgangArt.Ausbuchung, default, FremdSchadenAbrechnungArtType.Kosten)]
        [DataRow(8, BuchungsVorgangArt.Ausbuchung, default, FremdSchadenAbrechnungArtType.Kosten)]
        [DataRow(9, BuchungsVorgangArt.Ausbuchung, default, FremdSchadenAbrechnungArtType.Kosten)]
        [DataRow(10, BuchungsVorgangArt.Ausbuchung, default, FremdSchadenAbrechnungArtType.Kosten)]
        [TestCategory("UnitTest")]
        public void Test_if_CreateFremdschadenAbrechnungStrategy_CreateFremdschadenAbrechnung_works(
            long kontoArtBewegungId,
            BuchungsVorgangArt
                buchungsVorgangArt,
            BewegungsGruppeType bewegungsGruppe,
            FremdSchadenAbrechnungArtType expectedFremdSchadenAbrechnungArt)
        {
            throw new NotImplementedException();
        }
    }

    public enum FremdSchadenAbrechnungArtType
    {
        Eingang,
        Ausgang,
        Umbuchung,
        Kosten
    }

    public enum BewegungsGruppeType
    {
        EG,
        AG
    }

    public enum BuchungsVorgangArt
    {
        Bankbuchung,
        Umbuchung,
        Ausbuchung
    }
}
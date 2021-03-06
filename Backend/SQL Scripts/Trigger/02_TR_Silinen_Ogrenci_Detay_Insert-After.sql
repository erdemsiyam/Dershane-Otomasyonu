/* ogrenci_detay tablosundan bir ogrenci silindiğinde silinen_ogrenince_detay tablosunu eklenir.
Bu bir insert işlemi oldugundan silinen_ogrenci_detay tablosuna insert olayı gerçekleştiğinde biz
1-ogrenci_devamsizlik bilgilerini komple siliceğiz.
2-ogrenci_deneme bilgilerini komple siliceğiz.
3-Bu bilgileri sildikten sonra ogrenci tablosunu silebiliriz. */

---

CREATE TRIGGER TG_silinen_ogrenci_detay_tablosuna_ekleme_olunca ON silinen_ogrenci_detay AFTER INSERT
AS
	DECLARE @ogr_id INT
	SELECT @ogr_id = inserted.ogr_id FROM inserted
	PRINT('hELLOOO')
	DELETE FROM devamsizlik WHERE ogr_id=@ogr_id
	DELETE FROM ogrenci_deneme WHERE ogr_id=@ogr_id
	DELETE FROM ogrenci WHERE ogr_id= @ogr_id


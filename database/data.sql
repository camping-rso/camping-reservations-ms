\c kampi

INSERT INTO vrsta_kampiranja (vrsta_kampiranja_id, naziv) VALUES (1, 'Šotor');
INSERT INTO vrsta_kampiranja (vrsta_kampiranja_id, naziv) VALUES (2, 'Prikolica');
INSERT INTO vrsta_kampiranja (vrsta_kampiranja_id, naziv) VALUES (3, 'Avtodom');
INSERT INTO vrsta_kampiranja (vrsta_kampiranja_id, naziv) VALUES (4, 'Bungalov');
INSERT INTO vrsta_kampiranja (vrsta_kampiranja_id, naziv) VALUES (5, 'Mobilna hiška');

INSERT INTO public.status_rezervacije (status_rezervacije_id, naziv) VALUES (1, 'Uspešno');
INSERT INTO public.status_rezervacije (status_rezervacije_id, naziv) VALUES (2, 'Neuspešno');

INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (2, '2018-08-04 14:06:34', '2018-08-21 14:06:34', 2, 2, 2, 2, 2);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (1, '2018-07-21 14:06:34', '2019-07-25 14:06:34', 1, 1, 1, 1, 1);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (3, '2018-07-04 14:06:34', '2018-07-08 14:06:34', 2, 1, 4, 2, 2);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (7, '2019-12-28 22:50:52', '2019-12-28 22:50:52', 1, 1, 1, 1, 1);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (8, '2019-12-28 22:50:52', '2019-12-28 22:50:52', 1, 1, 1, 1, 1);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (11, '2019-12-28 17:17:16', '2019-12-30 17:17:16', 1, 3, 11, 1, 1);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (12, '2019-12-28 17:17:16', '2019-12-30 17:17:16', 1, 3, 11, 1, 1);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (13, '2020-01-02 00:00:00', '2020-01-23 00:00:00', 1, 3, 10, 1, 1);
INSERT INTO public.rezervacije (rezervacija_id, trajanje_od, trajanje_do, uporabnik, avtokamp, kampirno_mesto, vrsta_kampiranja, status_rezervacije) VALUES (14, '2019-12-28 17:17:16', '2019-12-30 17:17:16', 12, 3, 10, 1, 1);

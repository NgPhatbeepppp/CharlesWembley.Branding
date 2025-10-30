# UXD-04 — UI Kit & Design Tokens v1.0  
**Project:** Charles Wembley Corporate Branding Website  
**Designer:** Nguyễn Thành Phát  
**Completion Date:** 27 Oct 2025  
**Figma Reference:** [CLW Design System — Figma](https://www.figma.com/design/Sc0A40L1q3x38YK8i4VyB3/CLW?node-id=54-3117&t=m7gQtOBgUjV383nE-1)

---

## 1️⃣ Purpose
Thiết lập **bộ Design Tokens** và **UI Kit** chuẩn để bảo đảm tính nhất quán giữa thiết kế Figma và code (frontend / backend).  
Đây là đầu vào bắt buộc cho FE-Baseline (tuần 6) và FE-BR-01 / FE-BR-03 / FE-BR-05 theo WBS v2.

---

## 2️⃣ Color Palette

| Group | Token | Hex | RGB | Usage |
|-------|--------|-----|-----|--------|
| **White** | `--white-50 … 900` | `#ffffff → #6b6b6b` | (255,255,255) → (107,107,107) | Neutral BG, text, border |
| **Blue** (Primary) | `--blue-50 … 900` | `#e6edf5 → #002143` | (230,237,245) → (0,33,67) | Brand Medical Blue palette |
| **Yellow** (Accent) | `--yellow-50 … 900` | `#fef6dc → #686243` | (254,246,220) → (104,98,67) | Highlight / CTA accent |

**Primary brand color:** `--color-primary = #004F9F`  
**Accent color:** `--color-accent = #FFD43B`  
**Neutral background:** `--color-bg = #F9FAFB`

---

## 3️⃣ Typography Tokens

| Token | Font Family | Weight | Size (px) | Line Height | Usage |
|--------|-------------|---------|------------|--------------|--------|
| `--font-heading` | Montserrat | 700 (Bold) | 32 / 24 / 20 | 120 % | Headings H1–H3 |
| `--font-body` | Roboto | 400 / 500 | 16 / 14 | 150 % | Paragraph text |
| `--font-caption` | Roboto | 400 | 12 | 140 % | Label / Meta |
| `--font-brand` | Monsieur La Doulaise | 400 | 32–48 | 130 % | Logo / Brand signature |

---

## 4️⃣ Spacing & Grid System
| Token | Value | Description |
|--------|--------|-------------|
| `--spacing-unit` | 8 px (base unit) | Main spacing grid |
| `--grid-columns` | 12 cols | Desktop layout |
| `--grid-gutter` | 24 px | Column gap |
| `--container-max` | 1280 px | Main content width |
| `--breakpoint-desktop` | ≥ 1280 px | Desktop |
| `--breakpoint-tablet` | ≥ 768 px | Tablet |
| `--breakpoint-mobile` | < 768 px | Mobile |

---

## 5️⃣ Radius & Shadow Tokens
| Token | Type | Value | Usage |
|--------|------|--------|--------|
| `--radius-sm` | Border Radius | 4 px | Small buttons / inputs |
| `--radius-md` | Border Radius | 8 px | Default components |
| `--radius-lg` | Border Radius | 16 px | Cards / hero blocks |
| `--shadow-card` | Shadow | 0 2 8 rgba(0,0,0,0.08) | Cards / modal |
| `--shadow-hover` | Shadow | 0 4 12 rgba(0,0,0,0.10) | Hover state |

---

## 6️⃣ Core Components (atomic tokens)

| Component | Variants | Token Refs | Notes |
|------------|-----------|-------------|-------|
| **Button** | Primary / Secondary / Ghost | `--color-primary`, `--radius-md` | Hover contrast AA checked |
| **Input Field** | Default / Error / Disabled | `--spacing-unit`, `--shadow-card` | Border 1 px neutral 300 |
| **Card** | Default / Hover | `--shadow-card` → `--shadow-hover` | Padding = 2× unit |
| **Tag/Badge** | Neutral / Accent | `--color-accent`, `--radius-sm` | Uppercase Roboto 12 px |
| **Section BG** | White / Gray / Blue-tint | `--white-50 … blue-50` | Alternate layout blocks |

---

## 7️⃣ Accessibility & Contrast
- Tất cả màu chính đạt chuẩn **WCAG AA** (độ tương phản ≥ 4.5 : 1).  
- Button / link hover đạt ≥ AA; text trên background blue-500 và yellow-500 được xác nhận trong Figma plugin.  
- Font scale resizable (150 %) không phá layout.

---

## 8️⃣ Deliverables (UXD-04 Outputs)
| Deliverable | Description | Status |
|--------------|--------------|---------|
| 🎨 **UI Kit Figma Page** | Page “UI Kit / Design System” chứa màu, font, component tokens | ✅ Done |
| 📘 **Design Tokens Table** | Màu, typography, spacing, radius chuẩn | ✅ Done (đính kèm tài liệu này) |
| 🧱 **Component Library** | Button / Input / Card / Tag / Section Blocks | ✅ Done |
| 📁 **Figma Assets Link** | [CLW Design System Link](https://www.figma.com/design/Sc0A40L1q3x38YK8i4VyB3/CLW?node-id=54-3117&t=m7gQtOBgUjV383nE-1) | ✅ Available |

---

## 9️⃣ Definition of Done (UXD-04)
- [x] UI Kit documented (Figma + file .md).  
- [x] Tokens ready for Dev mapping to SCSS / CSS variables.  
- [x] Brand colors & font approved by internal review.  
- [x] Design system ≥ 80 % component reuse per UXD-01 goal.  
- [x] Reference saved in `/docs/UXD/UXD-04_UI-Kit_and_Design-Tokens_v1.md`.

---

## 🔚 Summary
Bộ **UI Kit v1** đặt nền cho việc map sang FE token (variables / Tailwind config) ở tuần 6 — FE-Baseline.  
Các token đã chuẩn hoá về tên và màu, đảm bảo tính thống nhất và sẵn sàng cho handoff UXD-07 → FE.

---

© Charles Wembley — Branding Rebuild Phase 1 (UIX v2)
